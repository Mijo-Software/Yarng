// HistoryDlg.cpp : implementation file
//

#include "stdafx.h"
#include "Yarng.h"
#include "HistoryDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CHistoryDlg dialog


CHistoryDlg::CHistoryDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CHistoryDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CHistoryDlg)
	m_strHistory = _T("");
	//}}AFX_DATA_INIT
  m_strHistory = "History\x0D\x0A======";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "xx.02.2008\x0D\x0A------------------\x0D\x0A* Yarng 1.0.7 was created";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "22.10.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.6.1 was created\x0D\x0A* Fixed a small bug and optimized the \x0D\x0A  performance";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "21.10.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.6 was created\x0D\x0A* This version was design to make a \x0D\x0A  better compatibility by 'emulation' with \x0D\x0A  the linux-app 'wine'. \x0D\x0A* Consequently some windows of the gui \x0D\x0A  were reformed \x0D\x0A* Added a status bar for some useful \x0D\x0A  information \x0D\x0A* Printing and exporting of the gene- \x0D\x0A  rated names are now possible; also \x0D\x0A  the generated names can be copied \x0D\x0A  to the clipboard\x0D\x0A* Removed 1 bug; two tooltips were \x0D\x0A  permuted";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "08.10.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.5.2 was created\x0D\x0A* Removed 1 bug; he was hidden in the \x0D\x0A  selection box of the language and was \x0D\x0A  found interestingly by 'emulation' with \x0D\x0A  the app 'wine' under the linux-os \x0D\x0A  'openSUSE 10.3'";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "20.06.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.5.1 was created\x0D\x0A* Removed 4 bugs ";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "19.06.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.5 was created\x0D\x0A* Added support for WinXP style \x0D\x0A* New improved gui \x0D\x0A* Removed some spelling mistakes \x0D\x0A* Optimized algorithm ";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "19.06.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.4 was created\x0D\x0A* Added hot-keys\x0D\x0A* Removed some spelling mistakes\x0D\x0A* Added character frequencies of some \x0D\x0A  languages as probablility of used \x0D\x0A  characters and 'Load' & 'Save'-Button \x0D\x0A* Fixed 'Cancel'-button in the dialog of \x0D\x0A  the probability table \x0D\x0A* Added 'Random'-button in the dialog of \x0D\x0A  the probability table \x0D\x0A* Optimized algorithm ";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "03.04.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.3.1 was created\x0D\x0A* Improved update in the probability table\x0D\x0A* Fixed some bugs from the last version";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "27.03.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.3 was created\x0D\x0A* Added probability table of characters\x0D\x0A* Removed some bugs";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "22.03.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.2.1 was created\x0D\x0A* Added some program informations";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "19.03.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.2 was created\x0D\x0A* You can choose, which characters \x0D\x0A  should use for random names\x0D\x0A* Added button for default settings \x0D\x0A* Added some useful buttons \x0D\x0A* Increased numeric validation from \x0D\x0A  255 -> 32000";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "18.03.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0.1 was created\x0D\x0A* Added some useful buttons";
  m_strHistory += "\x0D\x0A\x0D\x0A"; m_strHistory += "16.03.2007\x0D\x0A------------------\x0D\x0A* Yarng 1.0 was created";
}


void CHistoryDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CHistoryDlg)
	DDX_Text(pDX, IDC_EDIT_HISTORY, m_strHistory);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CHistoryDlg, CDialog)
	//{{AFX_MSG_MAP(CHistoryDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CHistoryDlg message handlers

BOOL CHistoryDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
  EnableThemeDialogTexture(GetSafeHwnd());
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
