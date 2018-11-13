// YarngDlg.cpp : implementation file
//

#include "stdafx.h"
#include "Yarng.h"
#include "YarngDlg.h"
#include "HistoryDlg.h"
#include "ExportDlg.h"
#include "HowtoDlg.h"
#include "ProbabilityDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	CHyperLink	m_Hyperlink1;
	CHyperLink	m_Hyperlink2;
	CHyperLink	m_EMailLink;
	CButton	m_btnOK;
	CString	m_strAbout;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	m_strAbout = _T("");
	//}}AFX_DATA_INIT
  m_strAbout = "Yarng ist an abbreviation for 'Yet another random name generator'. \x0D\x0A";
  m_strAbout += "It was developed to generate random names for extrasolar and fic- \x0D\x0A";
  m_strAbout += "tive planets, e. g. in Celestia. Of cause you can generate random \x0D\x0A";
  m_strAbout += "names for role plays and other related things.\x0D\x0A";
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	DDX_Control(pDX, IDC_EMAILLINK, m_EMailLink);
	DDX_Control(pDX, IDC_WWWLINK1, m_Hyperlink1);
	DDX_Control(pDX, IDC_WWWLINK2, m_Hyperlink2);
	DDX_Control(pDX, IDOK, m_btnOK);
	DDX_Text(pDX, IDC_EDIT_ABOUT, m_strAbout);
	//}}AFX_DATA_MAP
  m_EMailLink.SetURL(_T("mailto:michael-johne@gmx.de"));
  m_Hyperlink1.SetURL(_T("http://www.planeten.ch"));
  m_Hyperlink2.SetURL(_T("http://www.exodb.de.vu"));

}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CYarngDlg dialog

CYarngDlg::CYarngDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CYarngDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CYarngDlg)
	m_strGeneratedNames = _T("");
	m_nLengthOfNamesMax = 0;
	m_nLengthOfNamesMin = 0;
	m_nNumberOfNames = 0;
	m_strConsonants = _T("");
	m_strVowels = _T("");
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CYarngDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CYarngDlg)
	DDX_Control(pDX, IDC_SPIN_EDIT_MIN_LEN_OF_NAMES, m_sbMinLengthOfNames);
	DDX_Control(pDX, IDC_SPIN_EDIT_MAX_LEN_OF_NAMES, m_sbMaxLengthOfNames);
	DDX_Control(pDX, IDC_SPIN_NUMB_OF_NAMES, m_sbNumberOfNames);
	DDX_Control(pDX, IDC_BUTTON_PP_SCRAMBLE, m_btnPostProcessingScramble);
	DDX_Control(pDX, IDC_BUTTON_PP_MIRROR, m_btnPostProcessingMirror);
	DDX_Control(pDX, IDC_BUTTON_PP_RIGHT, m_btnPostProcessingRight);
	DDX_Control(pDX, IDC_BUTTON_PP_LEFT, m_btnPostProcessingLeft);
	DDX_Control(pDX, IDC_BUTTON_PP_AZ, m_btnPostProcessingAZ);
	DDX_Control(pDX, IDC_PROGRESS_GENERATE, m_prgsGenerate);
	DDX_Control(pDX, IDC_BUTTON_PRINT, m_btnPrint);
	DDX_Control(pDX, IDC_BUTTON_COPY, m_btnClipboard);
	DDX_Control(pDX, IDC_BUTTON_EXPORT, m_btnExport);
	DDX_Control(pDX, IDC_BUTTON_CLEAR, m_btnClear);
	DDX_Control(pDX, IDC_BUTTON_LNG_LOAD, m_btnLoad);
	DDX_Control(pDX, IDC_BUTTON_LNG_SAVE, m_btnSave);
	DDX_Control(pDX, IDC_BUTTON_PROBABILITY_TABLE, m_btnProbabilityTable);
	DDX_Control(pDX, IDC_BUTTON_HOWTO, m_btnHowto);
	DDX_Control(pDX, IDC_BUTTON_HISTORY, m_btnHistory);
	DDX_Control(pDX, IDC_BUTTON_DEFAULT_SETTINGS, m_btnDefaultSettings);
	DDX_Control(pDX, IDC_BUTTON_ABOUT, m_btnAbout);
	DDX_Control(pDX, IDC_BUTTON_EXIT, m_btnExit);
	DDX_Control(pDX, IDC_BUTTON_GENERATE, m_btnGenerate);
	DDX_Control(pDX, IDC_COMBO_LANGUAGE, m_cmbLanguage);
	DDX_Text(pDX, IDC_EDIT_GENERATED_NAMES, m_strGeneratedNames);
	DDX_Text(pDX, IDC_EDIT_MAX_LEN_OF_NAMES, m_nLengthOfNamesMax);
	DDV_MinMaxInt(pDX, m_nLengthOfNamesMax, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_MIN_LEN_OF_NAMES, m_nLengthOfNamesMin);
	DDV_MinMaxInt(pDX, m_nLengthOfNamesMin, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_NUMB_OF_NAMES, m_nNumberOfNames);
	DDV_MinMaxInt(pDX, m_nNumberOfNames, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_CONSONANTS, m_strConsonants);
	DDX_Text(pDX, IDC_EDIT_VOWELS, m_strVowels);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CYarngDlg, CDialog)
	//{{AFX_MSG_MAP(CYarngDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON_GENERATE, OnButtonGenerate)
	ON_BN_CLICKED(IDC_BUTTON_HISTORY, OnButtonHistory)
	ON_BN_CLICKED(IDC_BUTTON_ABOUT, OnButtonAbout)
	ON_BN_CLICKED(IDC_BUTTON_EXIT, OnButtonExit)
	ON_BN_CLICKED(IDC_BUTTON_HOWTO, OnButtonHowto)
	ON_BN_CLICKED(IDC_BUTTON_DEFAULT_SETTINGS, OnButtonDefaultSettings)
	ON_BN_CLICKED(IDC_BUTTON_PROBABILITY_TABLE, OnButtonProbabilityTable)
	ON_CBN_SELCHANGE(IDC_COMBO_LANGUAGE, OnSelchangeComboLanguage)
	ON_BN_CLICKED(IDC_BUTTON_LNG_LOAD, OnButtonLngLoad)
	ON_BN_CLICKED(IDC_BUTTON_LNG_SAVE, OnButtonLngSave)
	ON_BN_CLICKED(IDC_BUTTON_CLEAR, OnButtonClear)
	ON_BN_CLICKED(IDC_BUTTON_COPY, OnButtonCopy)
	ON_BN_CLICKED(IDC_BUTTON_EXPORT, OnButtonExport)
	ON_BN_CLICKED(IDC_BUTTON_PRINT, OnButtonPrint)
	ON_WM_TIMER()
	ON_BN_CLICKED(IDC_BUTTON_PP_LEFT, OnButtonPPLeft)
	ON_BN_CLICKED(IDC_BUTTON_PP_RIGHT, OnButtonPPRight)
	ON_BN_CLICKED(IDC_BUTTON_PP_MIRROR, OnButtonPPMirror)
	ON_BN_CLICKED(IDC_BUTTON_PP_AZ, OnButtonPPAz)
	ON_BN_CLICKED(IDC_BUTTON_PP_SCRAMBLE, OnButtonPPScramble)
	ON_EN_SETFOCUS(IDC_EDIT_NUMB_OF_NAMES, OnSetfocusEditNumbOfNames)
	ON_EN_SETFOCUS(IDC_EDIT_MAX_LEN_OF_NAMES, OnSetfocusEditMaxLenOfNames)
	ON_EN_SETFOCUS(IDC_EDIT_MIN_LEN_OF_NAMES, OnSetfocusEditMinLenOfNames)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CYarngDlg message handlers

BOOL CYarngDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	EnableThemeDialogTexture(GetSafeHwnd());
  static UINT BASED_CODE indicators[] =
  {                                    
    IDS_INDICATOR_NISH,
    IDS_INDICATOR_TIME
  };
  m_StatusBar.Create(this);
  m_StatusBar.SetIndicators(indicators,2);
  m_StatusBar.SetPaneInfo(0,IDS_INDICATOR_NISH,SBPS_NORMAL,315);
  m_StatusBar.SetPaneInfo(1,IDS_INDICATOR_TIME,SBPS_STRETCH,0);
  RepositionBars(AFX_IDW_CONTROLBAR_FIRST,AFX_IDW_CONTROLBAR_LAST,IDS_INDICATOR_TIME);
  SetTimer(100,1000,NULL);
  m_nLengthOfNamesMin = 3;
  m_nLengthOfNamesMax = 10;
  m_nNumberOfNames    = 10;
  m_uintProbabilityA = 10;
  m_uintProbabilityB = 10;
  m_uintProbabilityC = 10;
  m_uintProbabilityD = 10;
  m_uintProbabilityE = 10;
  m_uintProbabilityF = 10;
  m_uintProbabilityG = 10;
  m_uintProbabilityH = 10;
  m_uintProbabilityI = 10;
  m_uintProbabilityJ = 10;
  m_uintProbabilityK = 10;
  m_uintProbabilityL = 10;
  m_uintProbabilityM = 10;
  m_uintProbabilityN = 10;
  m_uintProbabilityO = 10;
  m_uintProbabilityP = 10;
  m_uintProbabilityQ = 10;
  m_uintProbabilityR = 10;
  m_uintProbabilityS = 10;
  m_uintProbabilityT = 10;
  m_uintProbabilityU = 10;
  m_uintProbabilityV = 10;
  m_uintProbabilityW = 10;
  m_uintProbabilityX = 10;
  m_uintProbabilityY = 10;
  m_uintProbabilityZ = 10;
  m_uintLanguageXX.SetSize(30);
  m_strVowels = "aeiou";
  m_strConsonants = "bcdfghjklmnpqrstvwxyz";
  m_strCharacters = m_strVowels + m_strConsonants;
  m_strGeneratedNames = "\x0D\x0A Click \"Generate!!!\" to \x0D\x0A create new random \x0D\x0A names.";
  m_cmbLanguage.SetCurSel(0);
  m_uintLanguage = m_cmbLanguage.GetCurSel();

  m_btnDefaultSettings.SetThemeHelper(&m_ThemeHelper);
  m_btnDefaultSettings.SetIcon(IDI_ICON_DEFAULTSETTINGS);
  m_btnDefaultSettings.DrawFlatFocus(true);
  m_btnDefaultSettings.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnDefaultSettings.SetTooltipText(IDS_DEFAULT_SETTINGS);

  m_btnProbabilityTable.SetThemeHelper(&m_ThemeHelper);
  m_btnProbabilityTable.SetIcon(IDI_ICON_PROBABILITYTABLE);
  m_btnProbabilityTable.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnProbabilityTable.DrawFlatFocus(true);
  m_btnProbabilityTable.SetTooltipText(IDS_PROBABILITY_TABLE);
  
  m_btnLoad.SetThemeHelper(&m_ThemeHelper);
  m_btnLoad.SetIcon(IDI_ICON_LOAD);
  m_btnLoad.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnLoad.DrawFlatFocus(true);
  m_btnLoad.SetTooltipText(IDS_LNG_LOAD);

  m_btnSave.SetThemeHelper(&m_ThemeHelper);
  m_btnSave.SetIcon(IDI_ICON_SAVE);
  m_btnSave.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnSave.DrawFlatFocus(true);
  m_btnSave.SetTooltipText(IDS_LNG_SAVE);

  m_btnGenerate.SetThemeHelper(&m_ThemeHelper);
  m_btnGenerate.SetIcon(IDI_ICON_GENERATE);
  m_btnGenerate.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnGenerate.DrawFlatFocus(true);
  m_btnGenerate.SetTooltipText(IDS_GENERATE);

  m_btnClear.SetThemeHelper(&m_ThemeHelper);
  m_btnClear.SetIcon(IDI_ICON_BLANK);
  m_btnClear.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnClear.DrawFlatFocus(true);
  m_btnClear.SetTooltipText(IDS_CLEAR);

  m_btnExport.SetThemeHelper(&m_ThemeHelper);
  m_btnExport.SetIcon(IDI_ICON_EXPORT);
  m_btnExport.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnExport.DrawFlatFocus(true);
  m_btnExport.SetTooltipText(IDS_EXPORT);

  m_btnClipboard.SetThemeHelper(&m_ThemeHelper);
  m_btnClipboard.SetIcon(IDI_ICON_COPY2);
  m_btnClipboard.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnClipboard.DrawFlatFocus(true);
  m_btnClipboard.SetTooltipText(IDS_COPY);

  m_btnPrint.SetThemeHelper(&m_ThemeHelper);
  m_btnPrint.SetIcon(IDI_ICON_PRINT2);
  m_btnPrint.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnPrint.DrawFlatFocus(true);
  m_btnPrint.SetTooltipText(IDS_PRINT);

  m_btnAbout.SetThemeHelper(&m_ThemeHelper);
  m_btnAbout.SetIcon(IDI_ICON_ABOUT);
  m_btnAbout.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnAbout.DrawFlatFocus(true);
  m_btnAbout.SetTooltipText(IDS_ABOUT);

  m_btnHistory.SetThemeHelper(&m_ThemeHelper);
  m_btnHistory.SetIcon(IDI_ICON_HISTORY);
  m_btnHistory.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnHistory.DrawFlatFocus(true);
  m_btnHistory.SetTooltipText(IDS_HISTORY);

  m_btnHowto.SetThemeHelper(&m_ThemeHelper);
  m_btnHowto.SetIcon(IDI_ICON_HOWTO);
  m_btnHowto.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnHowto.DrawFlatFocus(true);
  m_btnHowto.SetTooltipText(IDS_HOWTO);

  m_btnExit.SetThemeHelper(&m_ThemeHelper);
  m_btnExit.SetIcon(IDI_ICON_EXIT);
  m_btnExit.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnExit.DrawFlatFocus(true);
  m_btnExit.SetTooltipText(IDS_EXIT);
  
  m_btnPostProcessingLeft.SetThemeHelper(&m_ThemeHelper);
  m_btnPostProcessingLeft.SetIcon(IDI_ICON_LEFT);
  m_btnPostProcessingLeft.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnPostProcessingLeft.DrawFlatFocus(true);
  m_btnPostProcessingLeft.SetTooltipText(IDS_PP_LEFT);
  
  m_btnPostProcessingRight.SetThemeHelper(&m_ThemeHelper);
  m_btnPostProcessingRight.SetIcon(IDI_ICON_RIGHT);
  m_btnPostProcessingRight.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnPostProcessingRight.DrawFlatFocus(true);
  m_btnPostProcessingRight.SetTooltipText(IDS_PP_RIGHT);
  
  m_btnPostProcessingMirror.SetThemeHelper(&m_ThemeHelper);
  m_btnPostProcessingMirror.SetIcon(IDI_ICON_METAL);
  m_btnPostProcessingMirror.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnPostProcessingMirror.DrawFlatFocus(true);
  m_btnPostProcessingMirror.SetTooltipText(IDS_PP_MIRROR);

  m_btnPostProcessingAZ.SetThemeHelper(&m_ThemeHelper);
  m_btnPostProcessingAZ.SetIcon(IDI_ICON_AZ);
  m_btnPostProcessingAZ.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnPostProcessingAZ.DrawFlatFocus(true);
  m_btnPostProcessingAZ.SetTooltipText(IDS_PP_AZ);
  
  m_btnPostProcessingScramble.SetThemeHelper(&m_ThemeHelper);
  m_btnPostProcessingScramble.SetIcon(IDI_ICON_RANDOM);
  m_btnPostProcessingScramble.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnPostProcessingScramble.DrawFlatFocus(true);
  m_btnPostProcessingScramble.SetTooltipText(IDS_PP_SCRAMBLE);
 
  srand((unsigned)time(NULL));
  UpdateData(false);
  return TRUE;  // return TRUE  unless you set the focus to a control
}

void CYarngDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
  if ((nID & 0xFFF0) == IDM_ABOUTBOX)
  {
    CAboutDlg dlgAbout;
    dlgAbout.DoModal();
  } else {
    CDialog::OnSysCommand(nID, lParam);
  }
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CYarngDlg::OnPaint() 
{
  if (IsIconic())
  {
  CPaintDC dc(this); // device context for painting

  SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

  // Center icon in client rectangle
  int cxIcon = GetSystemMetrics(SM_CXICON);
  int cyIcon = GetSystemMetrics(SM_CYICON);
  CRect rect;
  GetClientRect(&rect);
  int x = (rect.Width() - cxIcon + 1) / 2;
  int y = (rect.Height() - cyIcon + 1) / 2;

  // Draw the icon
  dc.DrawIcon(x, y, m_hIcon);
  } else
  {
    CDialog::OnPaint();
  }
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CYarngDlg::OnQueryDragIcon()
{
  return (HCURSOR) m_hIcon;
}

void CYarngDlg::OnButtonGenerate() 
{
	// TODO: Add your control notification handler code here
  UpdateData(true);
  UpdateData(false);
  m_strGeneratedNames = "";
  int nOddEven = (rand() % 10);
  char chCharacter = ' ';
  int nCharacter = 0;
  CString strTemp = "",strTemp2 = "";
  CString strVowels2 = "", strConsonants2 = "";
  CString strAlphabet = "abcdefghijklmnopqrstuvwxyz";
  bool bNotFound = false;

  
  //for(int i = 0; i < m_strVowels.GetLength(); i++)
  //{
  //  for(int i = 1; i < 27; i++)
  //  {
  //    if (m_strVowels.Find(strAlphabet.GetAt(i)) == -1) bNotFound = true;
  //  }
  //}

  if (m_strVowels.Find("a") == -1)
  if (m_strVowels.Find("b") == -1)
  if (m_strVowels.Find("c") == -1)
  if (m_strVowels.Find("d") == -1)
  if (m_strVowels.Find("e") == -1)
  if (m_strVowels.Find("f") == -1)
  if (m_strVowels.Find("g") == -1)
  if (m_strVowels.Find("h") == -1)
  if (m_strVowels.Find("i") == -1)
  if (m_strVowels.Find("j") == -1)
  if (m_strVowels.Find("k") == -1)
  if (m_strVowels.Find("l") == -1)
  if (m_strVowels.Find("m") == -1)
  if (m_strVowels.Find("n") == -1)
  if (m_strVowels.Find("o") == -1)
  if (m_strVowels.Find("p") == -1)
  if (m_strVowels.Find("q") == -1)
  if (m_strVowels.Find("r") == -1)
  if (m_strVowels.Find("s") == -1)
  if (m_strVowels.Find("t") == -1)
  if (m_strVowels.Find("u") == -1)
  if (m_strVowels.Find("v") == -1)
  if (m_strVowels.Find("w") == -1)
  if (m_strVowels.Find("x") == -1)
  if (m_strVowels.Find("y") == -1)
  if (m_strVowels.Find("z") == -1) bNotFound = true;
  if (bNotFound == true)
  {
    m_strVowels = "aeiou";
    strVowels2 = m_strVowels;
    UpdateData(false);
    bNotFound = false;
  }

  if (m_strConsonants.Find("a") == -1)
  if (m_strConsonants.Find("b") == -1)
  if (m_strConsonants.Find("c") == -1)
  if (m_strConsonants.Find("d") == -1)
  if (m_strConsonants.Find("e") == -1)
  if (m_strConsonants.Find("f") == -1)
  if (m_strConsonants.Find("g") == -1)
  if (m_strConsonants.Find("h") == -1)
  if (m_strConsonants.Find("i") == -1)
  if (m_strConsonants.Find("j") == -1)
  if (m_strConsonants.Find("k") == -1)
  if (m_strConsonants.Find("l") == -1)
  if (m_strConsonants.Find("m") == -1)
  if (m_strConsonants.Find("n") == -1)
  if (m_strConsonants.Find("o") == -1)
  if (m_strConsonants.Find("p") == -1)
  if (m_strConsonants.Find("q") == -1)
  if (m_strConsonants.Find("r") == -1)
  if (m_strConsonants.Find("s") == -1)
  if (m_strConsonants.Find("t") == -1)
  if (m_strConsonants.Find("u") == -1)
  if (m_strConsonants.Find("v") == -1)
  if (m_strConsonants.Find("w") == -1)
  if (m_strConsonants.Find("x") == -1)
  if (m_strConsonants.Find("y") == -1)
  if (m_strConsonants.Find("z") == -1) bNotFound = true;
  if (bNotFound == true)
  {
    m_strConsonants = "bcdfghjklmnpqrstvwxyz";
    strConsonants2 = m_strConsonants;
    UpdateData(false);
    bNotFound = false;
  }
  if (m_strVowels == "")
  {
    m_strVowels = "aeiou";
    strVowels2 = m_strVowels;
    UpdateData(false);
  } else {
    for(int i = 0; i < m_strVowels.GetLength(); i++)
    {
      switch(m_strVowels.GetAt(i))
      {
        case 'a' : { for(UINT a = 0; a < m_uintProbabilityA; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'b' : { for(UINT a = 0; a < m_uintProbabilityB; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'c' : { for(UINT a = 0; a < m_uintProbabilityC; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'd' : { for(UINT a = 0; a < m_uintProbabilityD; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'e' : { for(UINT a = 0; a < m_uintProbabilityE; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'f' : { for(UINT a = 0; a < m_uintProbabilityF; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'g' : { for(UINT a = 0; a < m_uintProbabilityG; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'h' : { for(UINT a = 0; a < m_uintProbabilityH; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'i' : { for(UINT a = 0; a < m_uintProbabilityI; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'j' : { for(UINT a = 0; a < m_uintProbabilityJ; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'k' : { for(UINT a = 0; a < m_uintProbabilityK; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'l' : { for(UINT a = 0; a < m_uintProbabilityL; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'm' : { for(UINT a = 0; a < m_uintProbabilityM; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'n' : { for(UINT a = 0; a < m_uintProbabilityN; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'o' : { for(UINT a = 0; a < m_uintProbabilityO; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'p' : { for(UINT a = 0; a < m_uintProbabilityP; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'q' : { for(UINT a = 0; a < m_uintProbabilityQ; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'r' : { for(UINT a = 0; a < m_uintProbabilityR; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 's' : { for(UINT a = 0; a < m_uintProbabilityS; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 't' : { for(UINT a = 0; a < m_uintProbabilityT; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'u' : { for(UINT a = 0; a < m_uintProbabilityU; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'v' : { for(UINT a = 0; a < m_uintProbabilityV; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'w' : { for(UINT a = 0; a < m_uintProbabilityW; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'x' : { for(UINT a = 0; a < m_uintProbabilityX; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'y' : { for(UINT a = 0; a < m_uintProbabilityY; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
        case 'z' : { for(UINT a = 0; a < m_uintProbabilityZ; a++) { strVowels2 += m_strVowels.GetAt(i); } break; }
      }
    }            
  }
  if (m_strConsonants == "")
  {
    m_strConsonants = "bcdfghjklmnpqrstvwxyz";
    strConsonants2 = m_strConsonants;
    UpdateData(false);          
  } else {
    for(int i = 0; i < m_strConsonants.GetLength(); i++)
    {
      switch(m_strConsonants.GetAt(i))
      {
        case 'a' : { for(UINT a = 0; a < m_uintProbabilityA; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'b' : { for(UINT a = 0; a < m_uintProbabilityB; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'c' : { for(UINT a = 0; a < m_uintProbabilityC; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'd' : { for(UINT a = 0; a < m_uintProbabilityD; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'e' : { for(UINT a = 0; a < m_uintProbabilityE; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'f' : { for(UINT a = 0; a < m_uintProbabilityF; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'g' : { for(UINT a = 0; a < m_uintProbabilityG; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'h' : { for(UINT a = 0; a < m_uintProbabilityH; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'i' : { for(UINT a = 0; a < m_uintProbabilityI; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'j' : { for(UINT a = 0; a < m_uintProbabilityJ; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'k' : { for(UINT a = 0; a < m_uintProbabilityK; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'l' : { for(UINT a = 0; a < m_uintProbabilityL; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'm' : { for(UINT a = 0; a < m_uintProbabilityM; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'n' : { for(UINT a = 0; a < m_uintProbabilityN; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'o' : { for(UINT a = 0; a < m_uintProbabilityO; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'p' : { for(UINT a = 0; a < m_uintProbabilityP; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'q' : { for(UINT a = 0; a < m_uintProbabilityQ; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'r' : { for(UINT a = 0; a < m_uintProbabilityR; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 's' : { for(UINT a = 0; a < m_uintProbabilityS; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 't' : { for(UINT a = 0; a < m_uintProbabilityT; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'u' : { for(UINT a = 0; a < m_uintProbabilityU; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'v' : { for(UINT a = 0; a < m_uintProbabilityV; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'w' : { for(UINT a = 0; a < m_uintProbabilityW; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'x' : { for(UINT a = 0; a < m_uintProbabilityX; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'y' : { for(UINT a = 0; a < m_uintProbabilityY; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
        case 'z' : { for(UINT a = 0; a < m_uintProbabilityZ; a++) { strConsonants2 += m_strConsonants.GetAt(i); } break; }
      }
    }            
  }          

  if ((m_nLengthOfNamesMin <= m_nLengthOfNamesMax) || (m_nLengthOfNamesMin >= 1) && (m_nLengthOfNamesMax >= 1))
  {
    m_prgsGenerate.SetRange(0,m_nNumberOfNames-1);
    m_prgsGenerate.SetPos(0);
    for(int i = 1; i < m_nNumberOfNames+1; i++)
    {
      MSG msg;
	    while (PeekMessage(&msg,NULL,0,0,PM_REMOVE))
      {
    		TranslateMessage(&msg);
	    	DispatchMessage(&msg);
      }
      m_prgsGenerate.OffsetPos(1);
      strTemp = "";
      int nLengthOfNames = 0;
      while(nLengthOfNames < m_nLengthOfNamesMin)
      {
        nLengthOfNames = (rand() % m_nLengthOfNamesMax)+1;
      }    
      for(int n = 1; n < nLengthOfNames+1; n++)
      {
        if (nOddEven % 2 == 0)
        {
          nCharacter = 0;
          do
          {
            nCharacter = (rand() % strVowels2.GetLength());
          } while((nCharacter <= 1) && (nCharacter >= strVowels2.GetLength()));
          chCharacter = strVowels2.GetAt(nCharacter);
        } else if (nOddEven % 2 == 1) {
          nCharacter = 0;
          do
          {
            nCharacter = (rand() % strConsonants2.GetLength());
          } while((nCharacter <= 1) && (nCharacter >= strConsonants2.GetLength()));
          chCharacter = strConsonants2.GetAt(nCharacter);
        }
        strTemp += chCharacter;
        nOddEven++;
        if (n == 1) strTemp.MakeUpper();
      }
      strTemp2 += strTemp;
      if (i < m_nNumberOfNames) strTemp2 += ", \x0D\x0A";
    }
  } else {
    m_nLengthOfNamesMin = 3;
    m_nLengthOfNamesMax = 10;
    m_nNumberOfNames    = 10;
    strTemp2 = "";
  }
  UpdateData(true);
  m_strGeneratedNames = strTemp2;
  UpdateData(false);
}

void CYarngDlg::OnButtonAbout() 
{
  CAboutDlg dlgAbout;
  dlgAbout.DoModal();
}

void CYarngDlg::OnButtonHistory() 
{
  CHistoryDlg dlgHistory;
  dlgHistory.DoModal();
}

void CYarngDlg::OnButtonHowto() 
{
  CHowtoDlg dlgHowto;
  dlgHowto.DoModal();	
}

void CYarngDlg::OnButtonExit() 
{
  CDialog::OnCancel();
}

void CYarngDlg::OnButtonDefaultSettings() 
{
  m_nLengthOfNamesMin = 3;
  m_nLengthOfNamesMax = 10;
  m_nNumberOfNames    = 10;
  m_strConsonants = "bcdfghjklmnpqrstvwxyz";
  m_strVowels = "aeiou";
  m_uintProbabilityA = 10;
  m_uintProbabilityB = 10;
  m_uintProbabilityC = 10;
  m_uintProbabilityD = 10;
  m_uintProbabilityE = 10;
  m_uintProbabilityF = 10;
  m_uintProbabilityG = 10;
  m_uintProbabilityH = 10;
  m_uintProbabilityI = 10;
  m_uintProbabilityJ = 10;
  m_uintProbabilityK = 10;
  m_uintProbabilityL = 10;
  m_uintProbabilityM = 10;
  m_uintProbabilityN = 10;
  m_uintProbabilityO = 10;
  m_uintProbabilityP = 10;
  m_uintProbabilityQ = 10;
  m_uintProbabilityR = 10;
  m_uintProbabilityS = 10;
  m_uintProbabilityT = 10;
  m_uintProbabilityU = 10;
  m_uintProbabilityV = 10;
  m_uintProbabilityW = 10;
  m_uintProbabilityX = 10;
  m_uintProbabilityY = 10;
  m_uintProbabilityZ = 10;
  m_cmbLanguage.SetCurSel(0);
  m_uintLanguage = m_cmbLanguage.GetCurSel();
  UpdateData(false);
  MessageBox("The settings were resetted.","Default settings",MB_ICONINFORMATION);
}

void CYarngDlg::OnButtonProbabilityTable() 
{
  UpdateData(true);
  UpdateData(false);
  bool bCharacterIsUsed = false;
  UINT uintNumberOfCharacters = 0, uintSumOfCharacters = 0;
  CString strPercent = " %";
  float
    fProbabilityARelative = 0,
    fProbabilityBRelative = 0,
    fProbabilityCRelative = 0,
    fProbabilityDRelative = 0,
    fProbabilityERelative = 0,
    fProbabilityFRelative = 0,
    fProbabilityGRelative = 0,
    fProbabilityHRelative = 0,
    fProbabilityIRelative = 0,
    fProbabilityJRelative = 0,
    fProbabilityKRelative = 0,
    fProbabilityLRelative = 0,
    fProbabilityMRelative = 0,
    fProbabilityNRelative = 0,
    fProbabilityORelative = 0,
    fProbabilityPRelative = 0,
    fProbabilityQRelative = 0,
    fProbabilityRRelative = 0,
    fProbabilitySRelative = 0,
    fProbabilityTRelative = 0,
    fProbabilityURelative = 0,
    fProbabilityVRelative = 0,
    fProbabilityWRelative = 0,
    fProbabilityXRelative = 0,
    fProbabilityYRelative = 0,
    fProbabilityZRelative = 0;
  CProbabilityDlg dlgProbability;
  m_strCharacters = m_strVowels + m_strConsonants;
  dlgProbability.m_uintProbabilityA = m_uintProbabilityA;
  dlgProbability.m_uintProbabilityB = m_uintProbabilityB;
  dlgProbability.m_uintProbabilityC = m_uintProbabilityC;
  dlgProbability.m_uintProbabilityD = m_uintProbabilityD;
  dlgProbability.m_uintProbabilityE = m_uintProbabilityE;
  dlgProbability.m_uintProbabilityF = m_uintProbabilityF;
  dlgProbability.m_uintProbabilityG = m_uintProbabilityG;
  dlgProbability.m_uintProbabilityH = m_uintProbabilityH;
  dlgProbability.m_uintProbabilityI = m_uintProbabilityI;
  dlgProbability.m_uintProbabilityJ = m_uintProbabilityJ;
  dlgProbability.m_uintProbabilityK = m_uintProbabilityK;
  dlgProbability.m_uintProbabilityL = m_uintProbabilityL;
  dlgProbability.m_uintProbabilityM = m_uintProbabilityM;
  dlgProbability.m_uintProbabilityN = m_uintProbabilityN;
  dlgProbability.m_uintProbabilityO = m_uintProbabilityO;
  dlgProbability.m_uintProbabilityP = m_uintProbabilityP;
  dlgProbability.m_uintProbabilityQ = m_uintProbabilityQ;
  dlgProbability.m_uintProbabilityR = m_uintProbabilityR;
  dlgProbability.m_uintProbabilityS = m_uintProbabilityS;
  dlgProbability.m_uintProbabilityT = m_uintProbabilityT;
  dlgProbability.m_uintProbabilityU = m_uintProbabilityU;
  dlgProbability.m_uintProbabilityV = m_uintProbabilityV;
  dlgProbability.m_uintProbabilityW = m_uintProbabilityW;
  dlgProbability.m_uintProbabilityX = m_uintProbabilityX;
  dlgProbability.m_uintProbabilityY = m_uintProbabilityY;
  dlgProbability.m_uintProbabilityZ = m_uintProbabilityZ;
  
  for(int i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'a') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityA = 0;
  } else {
    if (dlgProbability.m_uintProbabilityA == 0)
    {
      dlgProbability.m_uintProbabilityA = 10;
      m_uintProbabilityA = 10;
    }
    uintSumOfCharacters += m_uintProbabilityA;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'b') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityB = 0;
    m_uintProbabilityB = 0;
  } else {
    if (dlgProbability.m_uintProbabilityB == 0)
    {
      dlgProbability.m_uintProbabilityB = 10;
      m_uintProbabilityB = 10;
    }
    uintSumOfCharacters += m_uintProbabilityB;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'c') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityC = 0;
    m_uintProbabilityC = 0;
  } else {
    if (dlgProbability.m_uintProbabilityC == 0)
    {
      dlgProbability.m_uintProbabilityC = 10;
      m_uintProbabilityC = 10;
    }
    uintSumOfCharacters += m_uintProbabilityC;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'd') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityD = 0;
    m_uintProbabilityD = 0;
  } else {
    if (dlgProbability.m_uintProbabilityD == 0)
    {
      dlgProbability.m_uintProbabilityD = 10;
      m_uintProbabilityD = 10;
    }
    uintSumOfCharacters += m_uintProbabilityD;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'e') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityE = 0;
    m_uintProbabilityE = 0;
  } else {
    if (dlgProbability.m_uintProbabilityE == 0)
    {
      dlgProbability.m_uintProbabilityE = 10;
      m_uintProbabilityE = 10;
    }
    uintSumOfCharacters += m_uintProbabilityE;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'f') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityF = 0;
    m_uintProbabilityF = 0;
  } else {
    if (dlgProbability.m_uintProbabilityF == 0)
    {
      dlgProbability.m_uintProbabilityF = 10;
      m_uintProbabilityF = 10;
    }
    uintSumOfCharacters += m_uintProbabilityF;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'g') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityG = 0;
    m_uintProbabilityG = 0;
  } else {
    if (dlgProbability.m_uintProbabilityG == 0)
    {
      dlgProbability.m_uintProbabilityG = 10;
      m_uintProbabilityG = 10;
    }
    uintSumOfCharacters += m_uintProbabilityG;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'h') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityH = 0;
    m_uintProbabilityH = 0;
  } else {
    if (dlgProbability.m_uintProbabilityH == 0)
    {
      dlgProbability.m_uintProbabilityH = 10;
      m_uintProbabilityH = 10;
    }
    uintSumOfCharacters += m_uintProbabilityH;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'i') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityI = 0;
    m_uintProbabilityI = 0;
  } else {
    if (dlgProbability.m_uintProbabilityI == 0)
    {
      dlgProbability.m_uintProbabilityI = 10;
      m_uintProbabilityI = 10;
    }
    uintSumOfCharacters += m_uintProbabilityI;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'j') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityJ = 0;
    m_uintProbabilityJ = 0;
  } else {
    if (dlgProbability.m_uintProbabilityJ == 0)
    {
      dlgProbability.m_uintProbabilityJ = 10;
      m_uintProbabilityJ = 10;
    }
    uintSumOfCharacters += m_uintProbabilityJ;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'k') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityK = 0;
    m_uintProbabilityK = 0;
  } else {
    if (dlgProbability.m_uintProbabilityK == 0)
    {
      dlgProbability.m_uintProbabilityK = 10;
      m_uintProbabilityK = 10;
    }
    uintSumOfCharacters += m_uintProbabilityK;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'l') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityL = 0;
    m_uintProbabilityL = 0;
  } else {
    if (dlgProbability.m_uintProbabilityL == 0)
    {
      dlgProbability.m_uintProbabilityL = 10;
      m_uintProbabilityL = 10;
    }
    uintSumOfCharacters += m_uintProbabilityL;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'm') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityM = 0;
    m_uintProbabilityM = 0;
  } else {
    if (dlgProbability.m_uintProbabilityM == 0)
    {
      dlgProbability.m_uintProbabilityM = 10;
      m_uintProbabilityM = 10;
    }
    uintSumOfCharacters += m_uintProbabilityM;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'n') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityN = 0;
    m_uintProbabilityN = 0;
  } else {
    if (dlgProbability.m_uintProbabilityN == 0)
    {
      dlgProbability.m_uintProbabilityN = 10;
      m_uintProbabilityN = 10;
    }
    uintSumOfCharacters += m_uintProbabilityN;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'o') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityO = 0;
    m_uintProbabilityO = 0;
  } else {
    if (dlgProbability.m_uintProbabilityO == 0)
    {
      dlgProbability.m_uintProbabilityO = 10;
      m_uintProbabilityO = 10;
    }
    uintSumOfCharacters += m_uintProbabilityO;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'p') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityP = 0;
    m_uintProbabilityP = 0;
  } else {
    if (dlgProbability.m_uintProbabilityP == 0)
    {
      dlgProbability.m_uintProbabilityP = 10;
      m_uintProbabilityP = 10;
    }
    uintSumOfCharacters += m_uintProbabilityP;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'q') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityQ = 0;
    m_uintProbabilityQ = 0;
  } else {
    if (dlgProbability.m_uintProbabilityQ == 0)
    {
      dlgProbability.m_uintProbabilityQ = 10;
      m_uintProbabilityQ = 10;
    }
    uintSumOfCharacters += m_uintProbabilityQ;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'r') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityR = 0;
    m_uintProbabilityR = 0;
  } else {
    if (dlgProbability.m_uintProbabilityR == 0)
    {
      dlgProbability.m_uintProbabilityR = 10;
      m_uintProbabilityR = 10;
    }
    uintSumOfCharacters += m_uintProbabilityR;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 's') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityS = 0;
    m_uintProbabilityS = 0;
  } else {
    if (dlgProbability.m_uintProbabilityS == 0)
    {
      dlgProbability.m_uintProbabilityS = 10;
      m_uintProbabilityS = 10;
    }
    uintSumOfCharacters += m_uintProbabilityS;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 't') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityT = 0;
    m_uintProbabilityT = 0;
  } else {
    if (dlgProbability.m_uintProbabilityT == 0)
    {
      dlgProbability.m_uintProbabilityT = 10;
      m_uintProbabilityT = 10;
    }
    uintSumOfCharacters += m_uintProbabilityT;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'u') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityU = 0;
    m_uintProbabilityU = 0;
  } else {
    if (dlgProbability.m_uintProbabilityU == 0)
    {
      dlgProbability.m_uintProbabilityU = 10;
      m_uintProbabilityU = 10;
    }
    uintSumOfCharacters += m_uintProbabilityU;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'v') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityV = 0;
    m_uintProbabilityV = 0;
  } else {
    if (dlgProbability.m_uintProbabilityV == 0)
    {
      dlgProbability.m_uintProbabilityV = 10;
      m_uintProbabilityV = 10;
    }
    uintSumOfCharacters += m_uintProbabilityV;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'w') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityW = 0;
    m_uintProbabilityW = 0;
  } else {
    if (dlgProbability.m_uintProbabilityW == 0)
    {
      dlgProbability.m_uintProbabilityW = 10;
      m_uintProbabilityW = 10;
    }
    uintSumOfCharacters += m_uintProbabilityW;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'x') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityX = 0;
    m_uintProbabilityX = 0;
  } else {
    if (dlgProbability.m_uintProbabilityX == 0)
    {
      dlgProbability.m_uintProbabilityX = 10;
      m_uintProbabilityX = 10;
    }
    uintSumOfCharacters += m_uintProbabilityX;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'y') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityY = 0;
    m_uintProbabilityY = 0;
  } else {
    if (dlgProbability.m_uintProbabilityY == 0)
    {
      dlgProbability.m_uintProbabilityY = 10;
      m_uintProbabilityY = 10;
    }
    uintSumOfCharacters += m_uintProbabilityY;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'z') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed)
  {
    dlgProbability.m_uintProbabilityZ = 0;
    m_uintProbabilityZ = 0;
  } else {
    if (dlgProbability.m_uintProbabilityZ == 0)
    {
      dlgProbability.m_uintProbabilityZ = 10;
      m_uintProbabilityZ = 10;
    }
    uintSumOfCharacters += m_uintProbabilityZ;
    uintNumberOfCharacters++;
    bCharacterIsUsed = false;
  }

  fProbabilityARelative = static_cast<float>(100*m_uintProbabilityA)/uintSumOfCharacters;
  fProbabilityBRelative = static_cast<float>(100*m_uintProbabilityB)/uintSumOfCharacters;
  fProbabilityCRelative = static_cast<float>(100*m_uintProbabilityC)/uintSumOfCharacters;
  fProbabilityDRelative = static_cast<float>(100*m_uintProbabilityD)/uintSumOfCharacters;
  fProbabilityERelative = static_cast<float>(100*m_uintProbabilityE)/uintSumOfCharacters;
  fProbabilityFRelative = static_cast<float>(100*m_uintProbabilityF)/uintSumOfCharacters;
  fProbabilityGRelative = static_cast<float>(100*m_uintProbabilityG)/uintSumOfCharacters;
  fProbabilityHRelative = static_cast<float>(100*m_uintProbabilityH)/uintSumOfCharacters;
  fProbabilityIRelative = static_cast<float>(100*m_uintProbabilityI)/uintSumOfCharacters;
  fProbabilityJRelative = static_cast<float>(100*m_uintProbabilityJ)/uintSumOfCharacters;
  fProbabilityKRelative = static_cast<float>(100*m_uintProbabilityK)/uintSumOfCharacters;
  fProbabilityLRelative = static_cast<float>(100*m_uintProbabilityL)/uintSumOfCharacters;
  fProbabilityMRelative = static_cast<float>(100*m_uintProbabilityM)/uintSumOfCharacters;
  fProbabilityNRelative = static_cast<float>(100*m_uintProbabilityN)/uintSumOfCharacters;
  fProbabilityORelative = static_cast<float>(100*m_uintProbabilityO)/uintSumOfCharacters;
  fProbabilityPRelative = static_cast<float>(100*m_uintProbabilityP)/uintSumOfCharacters;
  fProbabilityQRelative = static_cast<float>(100*m_uintProbabilityQ)/uintSumOfCharacters;
  fProbabilityRRelative = static_cast<float>(100*m_uintProbabilityR)/uintSumOfCharacters;
  fProbabilitySRelative = static_cast<float>(100*m_uintProbabilityS)/uintSumOfCharacters;
  fProbabilityTRelative = static_cast<float>(100*m_uintProbabilityT)/uintSumOfCharacters;
  fProbabilityURelative = static_cast<float>(100*m_uintProbabilityU)/uintSumOfCharacters;
  fProbabilityVRelative = static_cast<float>(100*m_uintProbabilityV)/uintSumOfCharacters;
  fProbabilityWRelative = static_cast<float>(100*m_uintProbabilityW)/uintSumOfCharacters;
  fProbabilityXRelative = static_cast<float>(100*m_uintProbabilityX)/uintSumOfCharacters;
  fProbabilityYRelative = static_cast<float>(100*m_uintProbabilityY)/uintSumOfCharacters;
  fProbabilityZRelative = static_cast<float>(100*m_uintProbabilityZ)/uintSumOfCharacters;

  dlgProbability.m_strProbabilityAPercent.Format("%.2f",fProbabilityARelative);
  dlgProbability.m_strProbabilityBPercent.Format("%.2f",fProbabilityBRelative);
  dlgProbability.m_strProbabilityCPercent.Format("%.2f",fProbabilityCRelative);
  dlgProbability.m_strProbabilityDPercent.Format("%.2f",fProbabilityDRelative);
  dlgProbability.m_strProbabilityEPercent.Format("%.2f",fProbabilityERelative);
  dlgProbability.m_strProbabilityFPercent.Format("%.2f",fProbabilityFRelative);
  dlgProbability.m_strProbabilityGPercent.Format("%.2f",fProbabilityGRelative);
  dlgProbability.m_strProbabilityHPercent.Format("%.2f",fProbabilityHRelative);
  dlgProbability.m_strProbabilityIPercent.Format("%.2f",fProbabilityIRelative);
  dlgProbability.m_strProbabilityJPercent.Format("%.2f",fProbabilityJRelative);
  dlgProbability.m_strProbabilityKPercent.Format("%.2f",fProbabilityKRelative);
  dlgProbability.m_strProbabilityLPercent.Format("%.2f",fProbabilityLRelative);
  dlgProbability.m_strProbabilityMPercent.Format("%.2f",fProbabilityMRelative);
  dlgProbability.m_strProbabilityNPercent.Format("%.2f",fProbabilityNRelative);
  dlgProbability.m_strProbabilityOPercent.Format("%.2f",fProbabilityORelative);
  dlgProbability.m_strProbabilityPPercent.Format("%.2f",fProbabilityPRelative);
  dlgProbability.m_strProbabilityQPercent.Format("%.2f",fProbabilityQRelative);
  dlgProbability.m_strProbabilityRPercent.Format("%.2f",fProbabilityRRelative);
  dlgProbability.m_strProbabilitySPercent.Format("%.2f",fProbabilitySRelative);
  dlgProbability.m_strProbabilityTPercent.Format("%.2f",fProbabilityTRelative);
  dlgProbability.m_strProbabilityUPercent.Format("%.2f",fProbabilityURelative);
  dlgProbability.m_strProbabilityVPercent.Format("%.2f",fProbabilityVRelative);
  dlgProbability.m_strProbabilityWPercent.Format("%.2f",fProbabilityWRelative);
  dlgProbability.m_strProbabilityXPercent.Format("%.2f",fProbabilityXRelative);
  dlgProbability.m_strProbabilityYPercent.Format("%.2f",fProbabilityYRelative);
  dlgProbability.m_strProbabilityZPercent.Format("%.2f",fProbabilityZRelative);
  dlgProbability.m_strProbabilityAPercent += strPercent;
  dlgProbability.m_strProbabilityBPercent += strPercent;
  dlgProbability.m_strProbabilityCPercent += strPercent;
  dlgProbability.m_strProbabilityDPercent += strPercent;
  dlgProbability.m_strProbabilityEPercent += strPercent;
  dlgProbability.m_strProbabilityFPercent += strPercent;
  dlgProbability.m_strProbabilityGPercent += strPercent;
  dlgProbability.m_strProbabilityHPercent += strPercent;
  dlgProbability.m_strProbabilityIPercent += strPercent;
  dlgProbability.m_strProbabilityJPercent += strPercent;
  dlgProbability.m_strProbabilityKPercent += strPercent;
  dlgProbability.m_strProbabilityLPercent += strPercent;
  dlgProbability.m_strProbabilityMPercent += strPercent;
  dlgProbability.m_strProbabilityNPercent += strPercent;
  dlgProbability.m_strProbabilityOPercent += strPercent;
  dlgProbability.m_strProbabilityPPercent += strPercent;
  dlgProbability.m_strProbabilityQPercent += strPercent;
  dlgProbability.m_strProbabilityRPercent += strPercent;
  dlgProbability.m_strProbabilitySPercent += strPercent;
  dlgProbability.m_strProbabilityTPercent += strPercent;
  dlgProbability.m_strProbabilityUPercent += strPercent;
  dlgProbability.m_strProbabilityVPercent += strPercent;
  dlgProbability.m_strProbabilityWPercent += strPercent;
  dlgProbability.m_strProbabilityXPercent += strPercent;
  dlgProbability.m_strProbabilityYPercent += strPercent;
  dlgProbability.m_strProbabilityZPercent += strPercent;

  dlgProbability.DoModal();
  UpdateData(true);

  m_uintProbabilityA = dlgProbability.m_uintProbabilityA;
  m_uintProbabilityB = dlgProbability.m_uintProbabilityB;
  m_uintProbabilityC = dlgProbability.m_uintProbabilityC;
  m_uintProbabilityD = dlgProbability.m_uintProbabilityD;
  m_uintProbabilityE = dlgProbability.m_uintProbabilityE;
  m_uintProbabilityF = dlgProbability.m_uintProbabilityF;
  m_uintProbabilityG = dlgProbability.m_uintProbabilityG;
  m_uintProbabilityH = dlgProbability.m_uintProbabilityH;
  m_uintProbabilityI = dlgProbability.m_uintProbabilityI;
  m_uintProbabilityJ = dlgProbability.m_uintProbabilityJ;
  m_uintProbabilityK = dlgProbability.m_uintProbabilityK;
  m_uintProbabilityL = dlgProbability.m_uintProbabilityL;
  m_uintProbabilityM = dlgProbability.m_uintProbabilityM;
  m_uintProbabilityN = dlgProbability.m_uintProbabilityN;
  m_uintProbabilityO = dlgProbability.m_uintProbabilityO;
  m_uintProbabilityP = dlgProbability.m_uintProbabilityP;
  m_uintProbabilityQ = dlgProbability.m_uintProbabilityQ;
  m_uintProbabilityR = dlgProbability.m_uintProbabilityR;
  m_uintProbabilityS = dlgProbability.m_uintProbabilityS;
  m_uintProbabilityT = dlgProbability.m_uintProbabilityT;
  m_uintProbabilityU = dlgProbability.m_uintProbabilityU;
  m_uintProbabilityV = dlgProbability.m_uintProbabilityV;
  m_uintProbabilityW = dlgProbability.m_uintProbabilityW;
  m_uintProbabilityX = dlgProbability.m_uintProbabilityX;
  m_uintProbabilityY = dlgProbability.m_uintProbabilityY;
  m_uintProbabilityZ = dlgProbability.m_uintProbabilityZ;

  m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);

  CString
    strMessage = "",
    strAddedPart = "A new character is added: ",
    strRemovedPart = "A existed character is removed: ";

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'a') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityA != 0)
  {
    m_strCharacters += "a";
    m_strVowels += "a";
    strMessage = strAddedPart + "'a' as vowel";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityA == 0)
      {
        m_strCharacters.Remove('a');
        m_strVowels.Remove('a');
        strMessage = strRemovedPart + "'a'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }
  
  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'b') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityB != 0)
  {
    m_strCharacters += "b";
    m_strConsonants += "b";
    strMessage = strAddedPart + "'b' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityB == 0)
      {
        m_strCharacters.Remove('b');
        m_strConsonants.Remove('b');
        strMessage = strRemovedPart + "'b'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'c') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityC != 0)
  {
    m_strCharacters += "c";
    m_strConsonants += "c";
    strMessage = strAddedPart + "'c' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityC == 0)
      {
        m_strCharacters.Remove('c');
        m_strConsonants.Remove('c');
        strMessage = strRemovedPart + "'c'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }
  
  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'd') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityD != 0)
  {
    m_strCharacters += "d";
    m_strConsonants += "d";
    strMessage = strAddedPart + "'d' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityD == 0)
      {
        m_strCharacters.Remove('d');
        m_strConsonants.Remove('d');
        strMessage = strRemovedPart + "'d'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'e') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityE != 0)
  {
    m_strCharacters += "e";
    m_strVowels += "e";
    strMessage = strAddedPart + "'e' as vowel";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityE == 0)
      {
        m_strCharacters.Remove('e');
        m_strVowels.Remove('e');
        strMessage = strRemovedPart + "'e'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'f') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityF != 0)
  {
    m_strCharacters += "f";
    m_strConsonants += "f";
    strMessage = strAddedPart + "'f' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityF == 0)
      {
        m_strCharacters.Remove('f');
        m_strConsonants.Remove('f');
        strMessage = strRemovedPart + "'f'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'g') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityG != 0)
  {
    m_strCharacters += "g";
    m_strConsonants += "g";
    strMessage = strAddedPart + "'g' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityG == 0)
      {
        m_strCharacters.Remove('g');
        m_strConsonants.Remove('g');
        strMessage = strRemovedPart + "'g'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'h') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityH != 0)
  {
    m_strCharacters += "h";
    m_strConsonants += "h";
    strMessage = strAddedPart + "'h' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityH == 0)
      {
        m_strCharacters.Remove('h');
        m_strConsonants.Remove('h');
        strMessage = strRemovedPart + "'h'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'i') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityI != 0)
  {
    m_strCharacters += "i";
    m_strVowels += "i";
    strMessage = strAddedPart + "'i' as vowel";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityI == 0)
      {
        m_strCharacters.Remove('i');
        m_strVowels.Remove('i');
        strMessage = strRemovedPart + "'i'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'j') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityJ != 0)
  {
    m_strCharacters += "j";
    m_strConsonants += "j";
    strMessage = strAddedPart + "'j' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityJ == 0)
      {
        m_strCharacters.Remove('j');
        m_strConsonants.Remove('j');
        strMessage = strRemovedPart + "'j'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'k') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityK != 0)
  {
    m_strCharacters += "k";
    m_strConsonants += "k";
    strMessage = strAddedPart + "'k' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityK == 0)
      {
        m_strCharacters.Remove('k');
        m_strConsonants.Remove('k');
        strMessage = strRemovedPart + "'k'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'l') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityL != 0)
  {
    m_strCharacters += "l";
    m_strConsonants += "l";
    strMessage = strAddedPart + "'l' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityL == 0)
      {
        m_strCharacters.Remove('l');
        m_strConsonants.Remove('l');
        strMessage = strRemovedPart + "'l'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'm') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityM != 0)
  {
    m_strCharacters += "m";
    m_strConsonants += "m";
    strMessage = strAddedPart + "'m' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityM == 0)
      {
        m_strCharacters.Remove('m');
        m_strConsonants.Remove('m');
        strMessage = strRemovedPart + "'m'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'n') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityN != 0)
  {
    m_strCharacters += "n";
    m_strConsonants += "n";
    strMessage = strAddedPart + "'n' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityN == 0)
      {
        m_strCharacters.Remove('n');
        m_strConsonants.Remove('n');
        strMessage = strRemovedPart + "'n'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'o') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityO != 0)
  {
    m_strCharacters += "o";
    m_strVowels += "o";
    strMessage = strAddedPart + "'o' as vowel";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityO == 0)
      {
        m_strCharacters.Remove('o');
        m_strVowels.Remove('o');
        strMessage = strRemovedPart + "'o'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'p') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityP != 0)
  {
    m_strCharacters += "p";
    m_strConsonants += "p";
    strMessage = strAddedPart + "'p' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityP == 0)
      {
        m_strCharacters.Remove('p');
        m_strConsonants.Remove('p');
        strMessage = strRemovedPart + "'p'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'q') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityQ != 0)
  {
    m_strCharacters += "q";
    m_strConsonants += "q";
    strMessage = strAddedPart + "'q' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityQ == 0)
      {
        m_strCharacters.Remove('q');
        m_strConsonants.Remove('q');
        strMessage = strRemovedPart + "'q'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'r') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityR != 0)
  {
    m_strCharacters += "r";
    m_strConsonants += "r";
    strMessage = strAddedPart + "'r' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityR == 0)
      {
        m_strCharacters.Remove('r');
        m_strConsonants.Remove('r');
        strMessage = strRemovedPart + "'r'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 's') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityS != 0)
  {
    m_strCharacters += "s";
    m_strConsonants += "s";
    strMessage = strAddedPart + "'s' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityS == 0)
      {
        m_strCharacters.Remove('s');
        m_strConsonants.Remove('s');
        strMessage = strRemovedPart + "'s'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'u') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityU != 0)
  {
    m_strCharacters += "u";
    m_strVowels += "u";
    strMessage = strAddedPart + "'u' as vowel";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityU == 0)
      {
        m_strCharacters.Remove('u');
        m_strVowels.Remove('u');
        strMessage = strRemovedPart + "'u'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'v') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityV != 0)
  {
    m_strCharacters += "v";
    m_strConsonants += "v";
    strMessage = strAddedPart + "'v' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityV == 0)
      {
        m_strCharacters.Remove('v');
        m_strConsonants.Remove('v');
        strMessage = strRemovedPart + "'v'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'w') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityW != 0)
  {
    m_strCharacters += "w";
    m_strConsonants += "w";
    strMessage = strAddedPart + "'w' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityW == 0)
      {
        m_strCharacters.Remove('w');
        m_strConsonants.Remove('w');
        strMessage = strRemovedPart + "'w'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'x') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityX != 0)
  {
    m_strCharacters += "x";
    m_strConsonants += "x";
    strMessage = strAddedPart + "'X' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityX == 0)
      {
        m_strCharacters.Remove('x');
        m_strConsonants.Remove('x');
        strMessage = strRemovedPart + "'x'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'y') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityY != 0)
  {
    m_strCharacters += "y";
    m_strConsonants += "y";
    strMessage = strAddedPart + "'y' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityY == 0)
      {
        m_strCharacters.Remove('y');
        m_strConsonants.Remove('y');
        strMessage = strRemovedPart + "'y'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }

  for(i = 0; i < m_strCharacters.GetLength(); i++) { if (m_strCharacters.GetAt(i) == 'z') bCharacterIsUsed = true; }
  if (!bCharacterIsUsed && dlgProbability.m_uintProbabilityZ != 0)
  {
    m_strCharacters += "z";
    m_strConsonants += "z";
    strMessage = strAddedPart + "'z' as consonant";
    m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
    MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
  } else {
    if (bCharacterIsUsed)
    {
      bCharacterIsUsed = false;
      if (dlgProbability.m_uintProbabilityZ == 0)
      {
        m_strCharacters.Remove('z');
        m_strConsonants.Remove('z');
        strMessage = strRemovedPart + "'z'";
        m_uintLanguage = 9; m_cmbLanguage.SetCurSel(9);
        MessageBox(strMessage,"Yarng",MB_ICONEXCLAMATION);
      }
    }
  }
  UpdateData(false);
}

void CYarngDlg::OnSelchangeComboLanguage() 
{
  UINT uintLanguageEN[26] = {1029,173,166,594,1276,245,157,882,551,42,61,342,265,743,678,122,1,496,581,880,229,101,200,4,177,7};
  UINT uintLanguageDE[26] = {651,189,306,508,1740,166,301,476,755,27,121,344,253,978,251,79,2,700,727,615,435,189,67,3,4,113};
  UINT uintLanguageES[26] = {1253,142,468,586,1368,69,101,70,625,44,0,497,315,671,868,251,88,687,798,463,393,90,2,22,90,52};
  UINT uintLanguageFR[26] = {764,90,326,367,1472,107,87,74,753,55,5,546,297,710,538,302,136,655,795,724,631,163,11,39,31,14};
  UINT uintLanguageNL[26] = {7,3,2,5,15,2,3,3,6,1,3,4,3,7,6,2,1,7,4,6,3,2,2,1,1,1};
  UINT uintLanguageIT[26] = {1174,92,450,373,1179,95,164,154,1128,0,0,651,251,688,983,305,51,637,498,562,301,210,0,49,0,0};
  UINT uintLanguageLT[26] = {837,161,340,326,1311,105,112,110,1110,0,0,257,565,586,507,241,167,612,746,868,809,156,0,58,11,4};
  UINT uintLanguagePR[26] = {1248,93,337,511,1259,105,126,129,612,34,2,315,457,495,1028,267,125,667,831,448,428,157,2,26,8,47};
  
  m_uintLanguage = m_cmbLanguage.GetCurSel();
  CString tmp;
  for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = 0;
	switch(m_uintLanguage)
	{
 	  case 0 : // not defined
	  {
      //m_strConsonants = "bcdfghjklmnpqrstvwxyz";
      //m_strVowels = "aeiou";
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = 10;
      break;
	  }
 	  case 1 : // english
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguageEN[i];
      break;
	  }
 	  case 2 : // german
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguageDE[i];
		  break;
	  }
 	  case 3 : // frence
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguageFR[i];
		  break;
	  }
 	  case 4 : // spanish
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguageES[i];
		  break;
	  }
 	  case 5 : // portuguese
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguagePR[i];
		  break;
	  }
 	  case 6 : // italian
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguageIT[i];
		  break;
	  }
 	  case 7 : // dutch
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguageNL[i];
		  break;
	  }
 	  case 8 : // latin
	  {
      for (UINT i = 0; i < 26; i++) m_uintLanguageXX[i] = uintLanguageLT[i];
		  break;
	  }
 	  case 9 : // user-defined
	  {
      m_uintLanguageXX[0] = m_uintProbabilityA;
      m_uintLanguageXX[1] = m_uintProbabilityB;
      m_uintLanguageXX[2] = m_uintProbabilityC;
      m_uintLanguageXX[3] = m_uintProbabilityD;
      m_uintLanguageXX[4] = m_uintProbabilityE;
      m_uintLanguageXX[5] = m_uintProbabilityF;
      m_uintLanguageXX[6] = m_uintProbabilityG;
      m_uintLanguageXX[7] = m_uintProbabilityH;
      m_uintLanguageXX[8] = m_uintProbabilityI;
      m_uintLanguageXX[9] = m_uintProbabilityJ;
      m_uintLanguageXX[10] = m_uintProbabilityK;
      m_uintLanguageXX[11] = m_uintProbabilityL;
      m_uintLanguageXX[12] = m_uintProbabilityM;
      m_uintLanguageXX[13] = m_uintProbabilityN;
      m_uintLanguageXX[14] = m_uintProbabilityO;
      m_uintLanguageXX[15] = m_uintProbabilityP;
      m_uintLanguageXX[16] = m_uintProbabilityQ;
      m_uintLanguageXX[17] = m_uintProbabilityR;
      m_uintLanguageXX[18] = m_uintProbabilityS;
      m_uintLanguageXX[19] = m_uintProbabilityT;
      m_uintLanguageXX[20] = m_uintProbabilityU;
      m_uintLanguageXX[21] = m_uintProbabilityV;
      m_uintLanguageXX[22] = m_uintProbabilityW;
      m_uintLanguageXX[23] = m_uintProbabilityX;
      m_uintLanguageXX[24] = m_uintProbabilityY;
      m_uintLanguageXX[25] = m_uintProbabilityZ;
		  break;
	  }
  }
  m_strVowels = "";
  m_strConsonants = "";  
  m_uintProbabilityA = m_uintLanguageXX[0]; if (m_uintProbabilityA != 0) m_strVowels += "a";
  m_uintProbabilityB = m_uintLanguageXX[1]; if (m_uintProbabilityB != 0) m_strConsonants += "b";
  m_uintProbabilityC = m_uintLanguageXX[2]; if (m_uintProbabilityC != 0) m_strConsonants += "c";
  m_uintProbabilityD = m_uintLanguageXX[3]; if (m_uintProbabilityD != 0) m_strConsonants += "d";
  m_uintProbabilityE = m_uintLanguageXX[4]; if (m_uintProbabilityE != 0) m_strVowels += "e";
  m_uintProbabilityF = m_uintLanguageXX[5]; if (m_uintProbabilityF != 0) m_strConsonants += "f";
  m_uintProbabilityG = m_uintLanguageXX[6]; if (m_uintProbabilityG != 0) m_strConsonants += "g";
  m_uintProbabilityH = m_uintLanguageXX[7]; if (m_uintProbabilityH != 0) m_strConsonants += "h";
  m_uintProbabilityI = m_uintLanguageXX[8]; if (m_uintProbabilityI != 0) m_strVowels += "i";
  m_uintProbabilityJ = m_uintLanguageXX[9]; if (m_uintProbabilityJ != 0) m_strConsonants += "j";
  m_uintProbabilityK = m_uintLanguageXX[10]; if (m_uintProbabilityK != 0) m_strConsonants += "k";
  m_uintProbabilityL = m_uintLanguageXX[11]; if (m_uintProbabilityL != 0) m_strConsonants += "l";
  m_uintProbabilityM = m_uintLanguageXX[12]; if (m_uintProbabilityM != 0) m_strConsonants += "m";
  m_uintProbabilityN = m_uintLanguageXX[13]; if (m_uintProbabilityN != 0) m_strConsonants += "n";
  m_uintProbabilityO = m_uintLanguageXX[14]; if (m_uintProbabilityO != 0) m_strVowels += "o";
  m_uintProbabilityP = m_uintLanguageXX[15]; if (m_uintProbabilityP != 0) m_strConsonants += "p";
  m_uintProbabilityQ = m_uintLanguageXX[16]; if (m_uintProbabilityQ != 0) m_strConsonants += "q";
  m_uintProbabilityR = m_uintLanguageXX[17]; if (m_uintProbabilityR != 0) m_strConsonants += "r";
  m_uintProbabilityS = m_uintLanguageXX[18]; if (m_uintProbabilityS != 0) m_strConsonants += "s";
  m_uintProbabilityT = m_uintLanguageXX[19]; if (m_uintProbabilityT != 0) m_strConsonants += "t";
  m_uintProbabilityU = m_uintLanguageXX[20]; if (m_uintProbabilityU != 0) m_strVowels += "u";
  m_uintProbabilityV = m_uintLanguageXX[21]; if (m_uintProbabilityV != 0) m_strConsonants += "v";
  m_uintProbabilityW = m_uintLanguageXX[22]; if (m_uintProbabilityW != 0) m_strConsonants += "w";
  m_uintProbabilityX = m_uintLanguageXX[23]; if (m_uintProbabilityX != 0) m_strConsonants += "x";
  m_uintProbabilityY = m_uintLanguageXX[24]; if (m_uintProbabilityY != 0) m_strConsonants += "y";
  m_uintProbabilityZ = m_uintLanguageXX[25]; if (m_uintProbabilityZ != 0) m_strConsonants += "z";
  m_strCharacters = m_strVowels + m_strConsonants;
  UpdateData(false);
}

void CYarngDlg::OnButtonLngLoad() 
{
	CFileDialog FileDialog(true,"","",OFN_FILEMUSTEXIST | OFN_HIDEREADONLY,"user-defined template (*.udt)|*.udt|");
  int nResult = FileDialog.DoModal();
  if (nResult == IDOK)
  {
    CString Filename = FileDialog.GetPathName();
    CStdioFile File;
    if (File.Open(LPCTSTR(Filename), CFile::modeRead))
    {
      CString tmp;
      File.ReadString(m_strVowels);
      File.ReadString(m_strConsonants);
      m_strCharacters = m_strVowels+m_strConsonants;
      for (UINT i = 0; i < 26; i++)
      {
        File.ReadString(tmp);
        m_uintLanguageXX[i] = atoi(tmp);
      }      
      m_uintProbabilityA = m_uintLanguageXX[0];
      m_uintProbabilityB = m_uintLanguageXX[1];
      m_uintProbabilityC = m_uintLanguageXX[2];
      m_uintProbabilityD = m_uintLanguageXX[3];
      m_uintProbabilityE = m_uintLanguageXX[4];
      m_uintProbabilityF = m_uintLanguageXX[5];
      m_uintProbabilityG = m_uintLanguageXX[6];
      m_uintProbabilityH = m_uintLanguageXX[7];
      m_uintProbabilityI = m_uintLanguageXX[8];
      m_uintProbabilityJ = m_uintLanguageXX[9];
      m_uintProbabilityK = m_uintLanguageXX[10];
      m_uintProbabilityL = m_uintLanguageXX[11];
      m_uintProbabilityM = m_uintLanguageXX[12];
      m_uintProbabilityN = m_uintLanguageXX[13];
      m_uintProbabilityO = m_uintLanguageXX[14];
      m_uintProbabilityP = m_uintLanguageXX[15];
      m_uintProbabilityQ = m_uintLanguageXX[16];
      m_uintProbabilityR = m_uintLanguageXX[17];
      m_uintProbabilityS = m_uintLanguageXX[18];
      m_uintProbabilityT = m_uintLanguageXX[19];
      m_uintProbabilityU = m_uintLanguageXX[20];
      m_uintProbabilityV = m_uintLanguageXX[21];
      m_uintProbabilityW = m_uintLanguageXX[22];
      m_uintProbabilityX = m_uintLanguageXX[23];
      m_uintProbabilityY = m_uintLanguageXX[24];
      m_uintProbabilityZ = m_uintLanguageXX[25];
      m_uintLanguage = 9;
      m_cmbLanguage.SetCurSel(m_uintLanguage);
      File.Close();
      UpdateData(false);
    }
  }
}

void CYarngDlg::OnButtonLngSave() 
{
	CFileDialog FileDialog(false,"","",OFN_FILEMUSTEXIST | OFN_HIDEREADONLY,"user-defined template (*.udt)|*.udt|");
  int nResult = FileDialog.DoModal();
  if (nResult == IDOK)
  {
    CString Filename = FileDialog.GetPathName();
    CStdioFile File;
    if (File.Open(LPCTSTR(Filename), CFile::modeCreate | CFile::modeWrite))
    {
      m_uintLanguageXX[0] = m_uintProbabilityA;
      m_uintLanguageXX[1] = m_uintProbabilityB;
      m_uintLanguageXX[2] = m_uintProbabilityC;
      m_uintLanguageXX[3] = m_uintProbabilityD;
      m_uintLanguageXX[4] = m_uintProbabilityE;
      m_uintLanguageXX[5] = m_uintProbabilityF;
      m_uintLanguageXX[6] = m_uintProbabilityG;
      m_uintLanguageXX[7] = m_uintProbabilityH;
      m_uintLanguageXX[8] = m_uintProbabilityI;
      m_uintLanguageXX[9] = m_uintProbabilityJ;
      m_uintLanguageXX[10] = m_uintProbabilityK;
      m_uintLanguageXX[11] = m_uintProbabilityL;
      m_uintLanguageXX[12] = m_uintProbabilityM;
      m_uintLanguageXX[13] = m_uintProbabilityN;
      m_uintLanguageXX[14] = m_uintProbabilityO;
      m_uintLanguageXX[15] = m_uintProbabilityP;
      m_uintLanguageXX[16] = m_uintProbabilityQ;
      m_uintLanguageXX[17] = m_uintProbabilityR;
      m_uintLanguageXX[18] = m_uintProbabilityS;
      m_uintLanguageXX[19] = m_uintProbabilityT;
      m_uintLanguageXX[20] = m_uintProbabilityU;
      m_uintLanguageXX[21] = m_uintProbabilityV;
      m_uintLanguageXX[22] = m_uintProbabilityW;
      m_uintLanguageXX[23] = m_uintProbabilityX;
      m_uintLanguageXX[24] = m_uintProbabilityY;
      m_uintLanguageXX[25] = m_uintProbabilityZ;
      CString tmp;
      File.WriteString(m_strVowels);
      File.WriteString("\n");
      File.WriteString(m_strConsonants);
      File.WriteString("\n");
      for (UINT i = 0; i < 26; i++)
      {
        tmp.Format("%d",m_uintLanguageXX[i]);
        tmp += "\n";
        File.WriteString(tmp);
      }
      File.Close();
    }
  }
}

BOOL CYarngDlg::PreTranslateMessage(MSG* pMsg) 
{
	CString strStaticTooltip;
  if (pMsg->message == WM_MOUSEMOVE)
	{
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_GENERATE)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_GENERATE);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_CLEAR)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_CLEAR);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_COPY)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_COPY);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_PRINT)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_PRINT);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_EXPORT)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_EXPORT);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_PROBABILITY_TABLE)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_PROBABILITY_TABLE);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_DEFAULT_SETTINGS)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_DEFAULT_SETTINGS);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_LNG_LOAD)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_LNG_LOAD);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_LNG_SAVE)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_LNG_SAVE);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_ABOUT)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_ABOUT);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_HISTORY)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_HISTORY);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_HOWTO)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_HOWTO);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_EXIT)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_EXIT);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_EDIT_NUMB_OF_NAMES)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_EDIT_NUMB_OF_NAMES);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_EDIT_MIN_LEN_OF_NAMES)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_EDIT_MIN_LEN_OF_NAMES);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_EDIT_MAX_LEN_OF_NAMES)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_EDIT_MAX_LEN_OF_NAMES);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_EDIT_VOWELS)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_EDIT_VOWELS);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_EDIT_CONSONANTS)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_EDIT_CONSONANTS);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_COMBO_LANGUAGE)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_COMBO_LANGUAGE);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_PP_LEFT)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_PP_LEFT);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_PP_RIGHT)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_PP_RIGHT);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_PP_MIRROR)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_PP_MIRROR);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_PP_AZ)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_PP_AZ);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
	  if (pMsg->hwnd == GetDlgItem(IDC_BUTTON_PP_SCRAMBLE)->m_hWnd)
    {
      strStaticTooltip.LoadString(IDS_PP_SCRAMBLE);
      m_StatusBar.SetPaneText(0,strStaticTooltip);
    } else 
    m_StatusBar.SetPaneText(0,"");
  }
	return CDialog::PreTranslateMessage(pMsg);
}

void CYarngDlg::OnButtonClear() 
{
	UpdateData(true);
	m_strGeneratedNames = "";
	UpdateData(false);
  m_prgsGenerate.SetPos(0);
}

void CYarngDlg::OnButtonCopy() 
{
  if (UpdateData())
  {
    CString strData;
    GetDlgItem(IDC_EDIT_GENERATED_NAMES)->GetWindowText(strData);
    if (OpenClipboard())
    {
      EmptyClipboard();
      HGLOBAL hClipboardData;
      hClipboardData = GlobalAlloc(GMEM_DDESHARE,strData.GetLength()+1);
      char *pchData;
      pchData = (char*)GlobalLock(hClipboardData);
      strcpy(pchData,LPCSTR(strData));
      GlobalUnlock(hClipboardData);
      SetClipboardData(CF_TEXT,hClipboardData);
      CloseClipboard();
    } else MessageBox("Clipboard is open","The clipboard is opened. Make sure that the clipboard is closed!",MB_OK+MB_ICONWARNING);
  }
}

void CYarngDlg::OnButtonExport() 
{
  CExportDlg dlgExport;
  dlgExport.m_strGeneratedNames = m_strGeneratedNames;
  dlgExport.DoModal();
}

void CYarngDlg::OnButtonPrint() 
{
  CPrintDialog dlgPrint(FALSE,PD_ALLPAGES,this);
  if (dlgPrint.DoModal() == IDOK)
  {
    CString strCreation,strID;
    CDC dcPrint;
    dcPrint.Attach(dlgPrint.GetPrinterDC());
    DOCINFO myPrintJob;
    myPrintJob.cbSize = sizeof(myPrintJob);
    myPrintJob.lpszDocName = "Yarng PrintJob";
    myPrintJob.lpszOutput = NULL;
    myPrintJob.lpszDatatype = NULL;
    myPrintJob.fwType = NULL;
    if (dcPrint.StartDoc(&myPrintJob) >= 0)
    {
      dcPrint.StartPage();
      CRect lpRect(100,100,4500,6000);
      m_strGeneratedNames.Replace("\x0D\x0A",NULL);
      CTime Time = CTime::GetCurrentTime();
      strCreation += "This file was created by ";
      strID.LoadString(IDS_PRODUCTNAME);
      strCreation += strID+" ";
      strID.LoadString(IDS_PRODUCTVERSION);
      strCreation += strID+" on ";
      strCreation += Time.Format("%y-%m-%d %H:%M:%S")+".\x0D\x0A\x0D\x0A";
      m_strGeneratedNames = strCreation+m_strGeneratedNames;
      dcPrint.DrawText(m_strGeneratedNames,lpRect,DT_LEFT | DT_NOCLIP | DT_WORDBREAK);
      dcPrint.EndPage();
      dcPrint.EndDoc();
    }
    dcPrint.DeleteDC();
  }
}

void CYarngDlg::OnTimer(UINT nIDEvent) 
{
  if(nIDEvent == 100) 
  {
    CTime Time;
    Time = CTime::GetCurrentTime();
    m_StatusBar.SetPaneText(1,Time.Format("%y-%m-%d %H:%M:%S"));
  }	
	CDialog::OnTimer(nIDEvent);
}

void CYarngDlg::OnButtonPPLeft() 
{
	// TODO: Add your control notification handler code here
	
}

void CYarngDlg::OnButtonPPRight() 
{
  CString strTemp;
  UpdateData(true);
  m_prgsGenerate.SetRange(0,m_strGeneratedNames.GetLength()-1);
  m_prgsGenerate.SetPos(0);  
  for (int i = 0; i < m_strGeneratedNames.GetLength()-1; i++)
  {
    m_prgsGenerate.OffsetPos(1);
    
    strTemp = m_strGeneratedNames.GetAt(0);
    //if (i != m_strGeneratedNames.GetLength()-1)
    m_strGeneratedNames.SetAt(i,m_strGeneratedNames.GetAt(i+1));
    m_strGeneratedNames.SetAt(m_strGeneratedNames.GetLength()-1,strTemp.GetAt(0));

    MSG msg;
    while (PeekMessage(&msg,NULL,0,0,PM_REMOVE))
    {
  		TranslateMessage(&msg);
    	DispatchMessage(&msg);
    }
  }
	UpdateData(false);
}

void CYarngDlg::OnButtonPPMirror() 
{
  CString strTemp;
  UpdateData(true);
  m_prgsGenerate.SetRange(0,m_strGeneratedNames.GetLength()-1);
  m_prgsGenerate.SetPos(0);
	m_strGeneratedNames.MakeReverse();
  m_strGeneratedNames.Replace("\x0A\x0D","\x0D\x0A");
  m_strGeneratedNames.Replace(" ,",", ");
  m_strGeneratedNames.Replace(", ",NULL);
  m_strGeneratedNames.Replace("\x0D\x0A",", \x0D\x0A");
  m_strGeneratedNames.MakeLower();
  for (int i = 0; i < m_strGeneratedNames.GetLength(); i++)
  {
    m_prgsGenerate.OffsetPos(1);
    if (m_strGeneratedNames.GetAt(i) == ' ') 
    {
      MSG msg;
	    while (PeekMessage(&msg,NULL,0,0,PM_REMOVE))
      {
    		TranslateMessage(&msg);
	    	DispatchMessage(&msg);
      }
      strTemp = m_strGeneratedNames.GetAt(i+3);
      strTemp.MakeUpper();
      m_strGeneratedNames.SetAt(i+3,strTemp.GetAt(0));
    }
  }
  strTemp = m_strGeneratedNames.GetAt(0);
  strTemp.MakeUpper();
  m_strGeneratedNames.SetAt(0,strTemp.GetAt(0));
	UpdateData(false);
}

void CYarngDlg::OnButtonPPAz() 
{
	// TODO: Add your control notification handler code here
	
}

void CYarngDlg::OnButtonPPScramble() 
{
}

/***********************************************************************************************************/
// Helper functions
/***********************************************************************************************************/
// constant string definitions here (or you can put it into resource string table)
#define IDS_UTIL_UXTHEME        "UxTheme.dll"
#define IDS_UTIL_THEMETEXTURE   "EnableThemeDialogTexture"
/////////////////////////////////////////////////////////////////////////////
void EnableThemeDialogTexture(HWND hwndDlg)
{
	HINSTANCE hDll=LoadLibrary(CString((LPCTSTR)IDS_UTIL_UXTHEME));							// 'UxTheme.dll'
	if(hDll==NULL)
		return;	// the DLL won't be available on anything except Windows XP
	ULONG (PASCAL *lpfnEnableTheme)(HWND, DWORD);
	(FARPROC&)lpfnEnableTheme=GetProcAddress(hDll,CString((LPCTSTR)IDS_UTIL_THEMETEXTURE));	// 'EnableThemeDialogTexture'
	if(lpfnEnableTheme)
		lpfnEnableTheme(hwndDlg, 6);		// ETDT_ENABLETAB = (ETDT_ENABLE | ETDT_USETABTEXTURE) = (2|4) = 6
	else ASSERT(FALSE);
	FreeLibrary(hDll);
}
/***********************************************************************************************************/
//
/***********************************************************************************************************/


BOOL CAboutDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();	
  //EnableThemeDialogTexture(GetSafeHwnd());
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CYarngDlg::OnSetfocusEditNumbOfNames() 
{
  m_sbNumberOfNames.SetRange(1,32000);
}

void CYarngDlg::OnSetfocusEditMaxLenOfNames() 
{
  m_sbMaxLengthOfNames.SetRange(1,32000);
}

void CYarngDlg::OnSetfocusEditMinLenOfNames() 
{
  m_sbMinLengthOfNames.SetRange(1,32000);
}
