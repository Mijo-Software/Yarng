# Microsoft Developer Studio Generated NMAKE File, Based on Yarng.dsp
!IF "$(CFG)" == ""
CFG=Yarng - Win32 Debug Static
!MESSAGE No configuration specified. Defaulting to Yarng - Win32 Debug Static.
!ENDIF 

!IF "$(CFG)" != "Yarng - Win32 Debug Shared" && "$(CFG)" != "Yarng - Win32 Debug Static" && "$(CFG)" != "Yarng - Win32 Release Shared" && "$(CFG)" != "Yarng - Win32 Release Static"
!MESSAGE Invalid configuration "$(CFG)" specified.
!MESSAGE You can specify a configuration when running NMAKE
!MESSAGE by defining the macro CFG on the command line. For example:
!MESSAGE 
!MESSAGE NMAKE /f "Yarng.mak" CFG="Yarng - Win32 Debug Static"
!MESSAGE 
!MESSAGE Possible choices for configuration are:
!MESSAGE 
!MESSAGE "Yarng - Win32 Debug Shared" (based on "Win32 (x86) Application")
!MESSAGE "Yarng - Win32 Debug Static" (based on "Win32 (x86) Application")
!MESSAGE "Yarng - Win32 Release Shared" (based on "Win32 (x86) Application")
!MESSAGE "Yarng - Win32 Release Static" (based on "Win32 (x86) Application")
!MESSAGE 
!ERROR An invalid configuration is specified.
!ENDIF 

!IF "$(OS)" == "Windows_NT"
NULL=
!ELSE 
NULL=nul
!ENDIF 

CPP=cl.exe
MTL=midl.exe
RSC=rc.exe

!IF  "$(CFG)" == "Yarng - Win32 Debug Shared"

OUTDIR=.\Debug_Shared
INTDIR=.\Debug_Shared
# Begin Custom Macros
OutDir=.\Debug_Shared
# End Custom Macros

ALL : "$(OUTDIR)\Yarng.exe" "$(OUTDIR)\Yarng.pch"


CLEAN :
	-@erase "$(INTDIR)\BCMenu.obj"
	-@erase "$(INTDIR)\BtnST.obj"
	-@erase "$(INTDIR)\ExportDlg.obj"
	-@erase "$(INTDIR)\HistoryDlg.obj"
	-@erase "$(INTDIR)\HowtoDlg.obj"
	-@erase "$(INTDIR)\HyperLink.obj"
	-@erase "$(INTDIR)\ProbabilityDlg.obj"
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(INTDIR)\ThemeHelperST.obj"
	-@erase "$(INTDIR)\vc60.idb"
	-@erase "$(INTDIR)\vc60.pdb"
	-@erase "$(INTDIR)\XPStyleButtonST.obj"
	-@erase "$(INTDIR)\XPTabCtrl.obj"
	-@erase "$(INTDIR)\Yarng.obj"
	-@erase "$(INTDIR)\Yarng.pch"
	-@erase "$(INTDIR)\Yarng.res"
	-@erase "$(INTDIR)\YarngDlg.obj"
	-@erase "$(OUTDIR)\Yarng.exe"
	-@erase "$(OUTDIR)\Yarng.ilk"
	-@erase "$(OUTDIR)\Yarng.pdb"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

CPP_PROJ=/nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_MBCS" /D "_AFXDLL" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /GZ /c 
MTL_PROJ=/nologo /D "_DEBUG" /mktyplib203 /win32 
RSC_PROJ=/l 0x809 /fo"$(INTDIR)\Yarng.res" /d "_DEBUG" /d "_AFXDLL" 
BSC32=bscmake.exe
BSC32_FLAGS=/nologo /o"$(OUTDIR)\Yarng.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
LINK32_FLAGS=/nologo /subsystem:windows /incremental:yes /pdb:"$(OUTDIR)\Yarng.pdb" /debug /machine:I386 /out:"$(OUTDIR)\Yarng.exe" /pdbtype:sept 
LINK32_OBJS= \
	"$(INTDIR)\BCMenu.obj" \
	"$(INTDIR)\BtnST.obj" \
	"$(INTDIR)\ExportDlg.obj" \
	"$(INTDIR)\HistoryDlg.obj" \
	"$(INTDIR)\HowtoDlg.obj" \
	"$(INTDIR)\HyperLink.obj" \
	"$(INTDIR)\ProbabilityDlg.obj" \
	"$(INTDIR)\StdAfx.obj" \
	"$(INTDIR)\ThemeHelperST.obj" \
	"$(INTDIR)\XPStyleButtonST.obj" \
	"$(INTDIR)\Yarng.obj" \
	"$(INTDIR)\YarngDlg.obj" \
	"$(INTDIR)\Yarng.res" \
	"$(INTDIR)\XPTabCtrl.obj"

"$(OUTDIR)\Yarng.exe" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

!ELSEIF  "$(CFG)" == "Yarng - Win32 Debug Static"

OUTDIR=.\Debug_Static
INTDIR=.\Debug_Static
# Begin Custom Macros
OutDir=.\Debug_Static
# End Custom Macros

ALL : "$(OUTDIR)\Yarng.exe" "$(OUTDIR)\Yarng.pch"


CLEAN :
	-@erase "$(INTDIR)\BCMenu.obj"
	-@erase "$(INTDIR)\BtnST.obj"
	-@erase "$(INTDIR)\ExportDlg.obj"
	-@erase "$(INTDIR)\HistoryDlg.obj"
	-@erase "$(INTDIR)\HowtoDlg.obj"
	-@erase "$(INTDIR)\HyperLink.obj"
	-@erase "$(INTDIR)\ProbabilityDlg.obj"
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(INTDIR)\ThemeHelperST.obj"
	-@erase "$(INTDIR)\vc60.idb"
	-@erase "$(INTDIR)\vc60.pdb"
	-@erase "$(INTDIR)\XPStyleButtonST.obj"
	-@erase "$(INTDIR)\XPTabCtrl.obj"
	-@erase "$(INTDIR)\Yarng.obj"
	-@erase "$(INTDIR)\Yarng.pch"
	-@erase "$(INTDIR)\Yarng.res"
	-@erase "$(INTDIR)\YarngDlg.obj"
	-@erase "$(OUTDIR)\Yarng.exe"
	-@erase "$(OUTDIR)\Yarng.ilk"
	-@erase "$(OUTDIR)\Yarng.pdb"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

CPP_PROJ=/nologo /MTd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_MBCS" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /GZ /c 
MTL_PROJ=/nologo /D "_DEBUG" /mktyplib203 /win32 
RSC_PROJ=/l 0x809 /fo"$(INTDIR)\Yarng.res" /d "_DEBUG" 
BSC32=bscmake.exe
BSC32_FLAGS=/nologo /o"$(OUTDIR)\Yarng.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
LINK32_FLAGS=/nologo /subsystem:windows /incremental:yes /pdb:"$(OUTDIR)\Yarng.pdb" /debug /machine:I386 /out:"$(OUTDIR)\Yarng.exe" /pdbtype:sept 
LINK32_OBJS= \
	"$(INTDIR)\BCMenu.obj" \
	"$(INTDIR)\BtnST.obj" \
	"$(INTDIR)\ExportDlg.obj" \
	"$(INTDIR)\HistoryDlg.obj" \
	"$(INTDIR)\HowtoDlg.obj" \
	"$(INTDIR)\HyperLink.obj" \
	"$(INTDIR)\ProbabilityDlg.obj" \
	"$(INTDIR)\StdAfx.obj" \
	"$(INTDIR)\ThemeHelperST.obj" \
	"$(INTDIR)\XPStyleButtonST.obj" \
	"$(INTDIR)\Yarng.obj" \
	"$(INTDIR)\YarngDlg.obj" \
	"$(INTDIR)\Yarng.res" \
	"$(INTDIR)\XPTabCtrl.obj"

"$(OUTDIR)\Yarng.exe" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

!ELSEIF  "$(CFG)" == "Yarng - Win32 Release Shared"

OUTDIR=.\Release_Shared
INTDIR=.\Release_Shared
# Begin Custom Macros
OutDir=.\Release_Shared
# End Custom Macros

ALL : "$(OUTDIR)\Yarng.exe"


CLEAN :
	-@erase "$(INTDIR)\BCMenu.obj"
	-@erase "$(INTDIR)\BtnST.obj"
	-@erase "$(INTDIR)\ExportDlg.obj"
	-@erase "$(INTDIR)\HistoryDlg.obj"
	-@erase "$(INTDIR)\HowtoDlg.obj"
	-@erase "$(INTDIR)\HyperLink.obj"
	-@erase "$(INTDIR)\ProbabilityDlg.obj"
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(INTDIR)\ThemeHelperST.obj"
	-@erase "$(INTDIR)\vc60.idb"
	-@erase "$(INTDIR)\XPStyleButtonST.obj"
	-@erase "$(INTDIR)\XPTabCtrl.obj"
	-@erase "$(INTDIR)\Yarng.obj"
	-@erase "$(INTDIR)\Yarng.pch"
	-@erase "$(INTDIR)\Yarng.res"
	-@erase "$(INTDIR)\YarngDlg.obj"
	-@erase "$(OUTDIR)\Yarng.exe"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

CPP_PROJ=/nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_MBCS" /D "_AFXDLL" /Fp"$(INTDIR)\Yarng.pch" /Yu"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /c 
MTL_PROJ=/nologo /D "NDEBUG" /mktyplib203 /win32 
RSC_PROJ=/l 0x407 /fo"$(INTDIR)\Yarng.res" /d "NDEBUG" /d "_AFXDLL" 
BSC32=bscmake.exe
BSC32_FLAGS=/nologo /o"$(OUTDIR)\Yarng.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
LINK32_FLAGS=/nologo /subsystem:windows /incremental:no /pdb:"$(OUTDIR)\Yarng.pdb" /machine:I386 /out:"$(OUTDIR)\Yarng.exe" 
LINK32_OBJS= \
	"$(INTDIR)\BCMenu.obj" \
	"$(INTDIR)\BtnST.obj" \
	"$(INTDIR)\ExportDlg.obj" \
	"$(INTDIR)\HistoryDlg.obj" \
	"$(INTDIR)\HowtoDlg.obj" \
	"$(INTDIR)\HyperLink.obj" \
	"$(INTDIR)\ProbabilityDlg.obj" \
	"$(INTDIR)\StdAfx.obj" \
	"$(INTDIR)\ThemeHelperST.obj" \
	"$(INTDIR)\XPStyleButtonST.obj" \
	"$(INTDIR)\Yarng.obj" \
	"$(INTDIR)\YarngDlg.obj" \
	"$(INTDIR)\Yarng.res" \
	"$(INTDIR)\XPTabCtrl.obj"

"$(OUTDIR)\Yarng.exe" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

!ELSEIF  "$(CFG)" == "Yarng - Win32 Release Static"

OUTDIR=.\Release_Static
INTDIR=.\Release_Static
# Begin Custom Macros
OutDir=.\Release_Static
# End Custom Macros

ALL : "$(OUTDIR)\Yarng.exe"


CLEAN :
	-@erase "$(INTDIR)\BCMenu.obj"
	-@erase "$(INTDIR)\BtnST.obj"
	-@erase "$(INTDIR)\ExportDlg.obj"
	-@erase "$(INTDIR)\HistoryDlg.obj"
	-@erase "$(INTDIR)\HowtoDlg.obj"
	-@erase "$(INTDIR)\HyperLink.obj"
	-@erase "$(INTDIR)\ProbabilityDlg.obj"
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(INTDIR)\ThemeHelperST.obj"
	-@erase "$(INTDIR)\vc60.idb"
	-@erase "$(INTDIR)\XPStyleButtonST.obj"
	-@erase "$(INTDIR)\XPTabCtrl.obj"
	-@erase "$(INTDIR)\Yarng.obj"
	-@erase "$(INTDIR)\Yarng.pch"
	-@erase "$(INTDIR)\Yarng.res"
	-@erase "$(INTDIR)\YarngDlg.obj"
	-@erase "$(OUTDIR)\Yarng.exe"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

CPP_PROJ=/nologo /MT /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_MBCS" /Fp"$(INTDIR)\Yarng.pch" /Yu"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /c 
MTL_PROJ=/nologo /D "NDEBUG" /mktyplib203 /win32 
RSC_PROJ=/l 0x407 /fo"$(INTDIR)\Yarng.res" /d "NDEBUG" 
BSC32=bscmake.exe
BSC32_FLAGS=/nologo /o"$(OUTDIR)\Yarng.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
LINK32_FLAGS=/nologo /subsystem:windows /incremental:no /pdb:"$(OUTDIR)\Yarng.pdb" /machine:I386 /out:"$(OUTDIR)\Yarng.exe" 
LINK32_OBJS= \
	"$(INTDIR)\BCMenu.obj" \
	"$(INTDIR)\BtnST.obj" \
	"$(INTDIR)\ExportDlg.obj" \
	"$(INTDIR)\HistoryDlg.obj" \
	"$(INTDIR)\HowtoDlg.obj" \
	"$(INTDIR)\HyperLink.obj" \
	"$(INTDIR)\ProbabilityDlg.obj" \
	"$(INTDIR)\StdAfx.obj" \
	"$(INTDIR)\ThemeHelperST.obj" \
	"$(INTDIR)\XPStyleButtonST.obj" \
	"$(INTDIR)\Yarng.obj" \
	"$(INTDIR)\YarngDlg.obj" \
	"$(INTDIR)\Yarng.res" \
	"$(INTDIR)\XPTabCtrl.obj"

"$(OUTDIR)\Yarng.exe" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

!ENDIF 

.c{$(INTDIR)}.obj::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cpp{$(INTDIR)}.obj::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cxx{$(INTDIR)}.obj::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.c{$(INTDIR)}.sbr::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cpp{$(INTDIR)}.sbr::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cxx{$(INTDIR)}.sbr::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<


!IF "$(NO_EXTERNAL_DEPS)" != "1"
!IF EXISTS("Yarng.dep")
!INCLUDE "Yarng.dep"
!ELSE 
!MESSAGE Warning: cannot find "Yarng.dep"
!ENDIF 
!ENDIF 


!IF "$(CFG)" == "Yarng - Win32 Debug Shared" || "$(CFG)" == "Yarng - Win32 Debug Static" || "$(CFG)" == "Yarng - Win32 Release Shared" || "$(CFG)" == "Yarng - Win32 Release Static"
SOURCE=.\BCMenu.cpp

"$(INTDIR)\BCMenu.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\BtnST.cpp

"$(INTDIR)\BtnST.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\ExportDlg.cpp

"$(INTDIR)\ExportDlg.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\HistoryDlg.cpp

"$(INTDIR)\HistoryDlg.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\HowtoDlg.cpp

"$(INTDIR)\HowtoDlg.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\HyperLink.cpp

"$(INTDIR)\HyperLink.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\ProbabilityDlg.cpp

"$(INTDIR)\ProbabilityDlg.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\StdAfx.cpp

!IF  "$(CFG)" == "Yarng - Win32 Debug Shared"

CPP_SWITCHES=/nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_MBCS" /D "_AFXDLL" /Fp"$(INTDIR)\Yarng.pch" /Yc"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /GZ /c 

"$(INTDIR)\StdAfx.obj"	"$(INTDIR)\Yarng.pch" : $(SOURCE) "$(INTDIR)"
	$(CPP) @<<
  $(CPP_SWITCHES) $(SOURCE)
<<


!ELSEIF  "$(CFG)" == "Yarng - Win32 Debug Static"

CPP_SWITCHES=/nologo /MTd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_MBCS" /Fp"$(INTDIR)\Yarng.pch" /Yc"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /GZ /c 

"$(INTDIR)\StdAfx.obj"	"$(INTDIR)\Yarng.pch" : $(SOURCE) "$(INTDIR)"
	$(CPP) @<<
  $(CPP_SWITCHES) $(SOURCE)
<<


!ELSEIF  "$(CFG)" == "Yarng - Win32 Release Shared"

CPP_SWITCHES=/nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_MBCS" /D "_AFXDLL" /Fp"$(INTDIR)\Yarng.pch" /Yc"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /c 

"$(INTDIR)\StdAfx.obj"	"$(INTDIR)\Yarng.pch" : $(SOURCE) "$(INTDIR)"
	$(CPP) @<<
  $(CPP_SWITCHES) $(SOURCE)
<<


!ELSEIF  "$(CFG)" == "Yarng - Win32 Release Static"

CPP_SWITCHES=/nologo /MT /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_MBCS" /Fp"$(INTDIR)\Yarng.pch" /Yc"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /c 

"$(INTDIR)\StdAfx.obj"	"$(INTDIR)\Yarng.pch" : $(SOURCE) "$(INTDIR)"
	$(CPP) @<<
  $(CPP_SWITCHES) $(SOURCE)
<<


!ENDIF 

SOURCE=.\ThemeHelperST.cpp

"$(INTDIR)\ThemeHelperST.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\XPStyleButtonST.cpp

"$(INTDIR)\XPStyleButtonST.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\XPTabCtrl.cpp

"$(INTDIR)\XPTabCtrl.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\Yarng.cpp

"$(INTDIR)\Yarng.obj" : $(SOURCE) "$(INTDIR)"


SOURCE=.\Yarng.rc

"$(INTDIR)\Yarng.res" : $(SOURCE) "$(INTDIR)"
	$(RSC) $(RSC_PROJ) $(SOURCE)


SOURCE=.\YarngDlg.cpp

"$(INTDIR)\YarngDlg.obj" : $(SOURCE) "$(INTDIR)"



!ENDIF 

