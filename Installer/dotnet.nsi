 Function CheckAndDownloadDotNet45
	# Let's see if the user has the .NET Framework 4.5 installed on their system or not
	# Remember: you need Vista SP2 or 7 SP1.  It is built in to Windows 8, and not needed
	# In case you're wondering, running this code on Windows 8 will correctly return is_equal
	# or is_greater (maybe Microsoft releases .NET 4.5 SP1 for example)
 
	# Set up our Variables
	Var /GLOBAL dotNET45IsThere
	Var /GLOBAL dotNET_CMD_LINE
	Var /GLOBAL EXIT_CODE
 
        # We are reading a version release DWORD that Microsoft says is the documented
        # way to determine if .NET Framework 4.5 is installed
	ReadRegDWORD $dotNET45IsThere HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" "Release"
	IntCmp $dotNET45IsThere 378389 is_equal is_less is_greater
 
	is_equal:
		Goto done_compare_not_needed
	is_greater:
		# Useful if, for example, Microsoft releases .NET 4.5 SP1
		# We want to be able to simply skip install since it's not
		# needed on this system
		Goto done_compare_not_needed
	is_less:
		Goto done_compare_needed
 
	done_compare_needed:
		#.NET Framework 4.5 install is *NEEDED*
 
		# Microsoft Download Center EXE:
		# Web Bootstrapper: http://go.microsoft.com/fwlink/?LinkId=225704
		# Full Download: http://go.microsoft.com/fwlink/?LinkId=225702
 
		# Setup looks for components\dotNET45Full.exe relative to the install EXE location
		# This allows the installer to be placed on a USB stick (for computers without internet connections)
		# If the .NET Framework 4.5 installer is *NOT* found, Setup will connect to Microsoft's website
		# and download it for you
 
		# Reboot Required with these Exit Codes:
		# 1641 or 3010
 
		# Command Line Switches:
		# /showrmui /passive /norestart
 
		# Silent Command Line Switches:
		# /q /norestart
 
 
		# Let's see if the user is doing a Silent install or not
		IfSilent is_quiet is_not_quiet
 
		is_quiet:
			StrCpy $dotNET_CMD_LINE "/q /norestart"
			Goto LookForLocalFile
		is_not_quiet:
			StrCpy $dotNET_CMD_LINE "/showrmui /passive /norestart"
			Goto LookForLocalFile
 
		LookForLocalFile:
			# Let's see if the user stored the Full Installer
			IfFileExists "$EXEPATH\components\dotNET45Full.exe" do_local_install do_network_install
 
			do_local_install:
				# .NET Framework found on the local disk.  Use this copy
 
				ExecWait '"$EXEPATH\components\dotNET45Full.exe" $dotNET_CMD_LINE' $EXIT_CODE
				Goto is_reboot_requested
 
			# Now, let's Download the .NET
			do_network_install:
 
				Var /GLOBAL dotNetDidDownload
				NSISdl::download "http://go.microsoft.com/fwlink/?LinkId=225704" "$TEMP\dotNET45Web.exe" $dotNetDidDownload
 
				StrCmp $dotNetDidDownload success fail
				success:
					ExecWait '"$TEMP\dotNET45Web.exe" $dotNET_CMD_LINE' $EXIT_CODE
					Goto is_reboot_requested
 
				fail:
					MessageBox MB_OK|MB_ICONEXCLAMATION "Unable to download .NET Framework.  OPEA Manager will be installed, but will not function without the Framework!"
					Goto done_dotNET_function
 
				# $EXIT_CODE contains the return codes.  1641 and 3010 means a Reboot has been requested
				is_reboot_requested:
				#	${If} $EXIT_CODE == 1641
				#		SetRebootFlag true
				#	${EndIf}
				#	${If} $EXIT_CODE == 3010
				#		SetRebootFlag true
				#	${EndIf}
 
	done_compare_not_needed:
		# Done dotNET Install
		Goto done_dotNET_function
 
	#exit the function
	done_dotNET_function:
 
    FunctionEnd