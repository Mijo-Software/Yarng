// ProbabilityDlg.cpp : implementation file
//

#include "stdafx.h"
#include "Yarng.h"
#include "ProbabilityDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CProbabilityDlg dialog


CProbabilityDlg::CProbabilityDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CProbabilityDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CProbabilityDlg)
  m_uintProbabilityA = 1;
  m_uintProbabilityB = 1;
  m_uintProbabilityC = 1;
  m_uintProbabilityD = 1;
  m_uintProbabilityE = 1;
  m_uintProbabilityF = 1;
  m_uintProbabilityG = 1;
  m_uintProbabilityH = 1;
  m_uintProbabilityI = 1;
  m_uintProbabilityJ = 1;
  m_uintProbabilityK = 1;
  m_uintProbabilityL = 1;
  m_uintProbabilityM = 1;
  m_uintProbabilityN = 1;
  m_uintProbabilityO = 1;
  m_uintProbabilityP = 1;
  m_uintProbabilityR = 1;
  m_uintProbabilityQ = 1;
  m_uintProbabilityS = 1;
  m_uintProbabilityT = 1;
  m_uintProbabilityU = 1;
  m_uintProbabilityV = 1;
  m_uintProbabilityW = 1;
  m_uintProbabilityX = 1;
  m_uintProbabilityY = 1;
  m_uintProbabilityZ = 1;
  m_uintProbabilityA_Copy = 1;
  m_uintProbabilityB_Copy = 1;
  m_uintProbabilityC_Copy = 1;
  m_uintProbabilityD_Copy = 1;
  m_uintProbabilityE_Copy = 1;
  m_uintProbabilityF_Copy = 1;
  m_uintProbabilityG_Copy = 1;
  m_uintProbabilityH_Copy = 1;
  m_uintProbabilityI_Copy = 1;
  m_uintProbabilityJ_Copy = 1;
  m_uintProbabilityK_Copy = 1;
  m_uintProbabilityL_Copy = 1;
  m_uintProbabilityM_Copy = 1;
  m_uintProbabilityN_Copy = 1;
  m_uintProbabilityO_Copy = 1;
  m_uintProbabilityP_Copy = 1;
  m_uintProbabilityR_Copy = 1;
  m_uintProbabilityQ_Copy = 1;
  m_uintProbabilityS_Copy = 1;
  m_uintProbabilityT_Copy = 1;
  m_uintProbabilityU_Copy = 1;
  m_uintProbabilityV_Copy = 1;
  m_uintProbabilityW_Copy = 1;
  m_uintProbabilityX_Copy = 1;
  m_uintProbabilityY_Copy = 1;
  m_uintProbabilityZ_Copy = 1;
  m_fProbabilityARelative = 0;
  m_fProbabilityBRelative = 0;
  m_fProbabilityCRelative = 0;
  m_fProbabilityDRelative = 0;
  m_fProbabilityERelative = 0;
  m_fProbabilityFRelative = 0;
  m_fProbabilityGRelative = 0;
  m_fProbabilityHRelative = 0;
  m_fProbabilityIRelative = 0;
  m_fProbabilityJRelative = 0;
  m_fProbabilityKRelative = 0;
  m_fProbabilityLRelative = 0;
  m_fProbabilityMRelative = 0;
  m_fProbabilityNRelative = 0;
  m_fProbabilityORelative = 0;
  m_fProbabilityPRelative = 0;
  m_fProbabilityQRelative = 0;
  m_fProbabilityRRelative = 0;
  m_fProbabilitySRelative = 0;
  m_fProbabilityTRelative = 0;
  m_fProbabilityURelative = 0;
  m_fProbabilityVRelative = 0;
  m_fProbabilityWRelative = 0;
  m_fProbabilityXRelative = 0;
  m_fProbabilityYRelative = 0;
  m_fProbabilityZRelative = 0;
	m_strProbabilityAPercent = _T("");
	m_strProbabilityBPercent = _T("");
	m_strProbabilityCPercent = _T("");
	m_strProbabilityDPercent = _T("");
	m_strProbabilityEPercent = _T("");
	m_strProbabilityFPercent = _T("");
	m_strProbabilityGPercent = _T("");
	m_strProbabilityHPercent = _T("");
	m_strProbabilityIPercent = _T("");
	m_strProbabilityJPercent = _T("");
	m_strProbabilityKPercent = _T("");
	m_strProbabilityLPercent = _T("");
	m_strProbabilityMPercent = _T("");
	m_strProbabilityNPercent = _T("");
	m_strProbabilityOPercent = _T("");
	m_strProbabilityPPercent = _T("");
	m_strProbabilityQPercent = _T("");
	m_strProbabilityRPercent = _T("");
	m_strProbabilitySPercent = _T("");
	m_strProbabilityTPercent = _T("");
	m_strProbabilityUPercent = _T("");
	m_strProbabilityVPercent = _T("");
	m_strProbabilityWPercent = _T("");
	m_strProbabilityXPercent = _T("");
	m_strProbabilityYPercent = _T("");
	m_strProbabilityZPercent = _T("");
	//}}AFX_DATA_INIT
}

void CProbabilityDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CProbabilityDlg)
	DDX_Control(pDX, IDOK, m_btnOK);
	DDX_Control(pDX, IDCANCEL, m_btnCancel);
	DDX_Control(pDX, ID_BUTTON_RANDOM, m_btnRandom);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_A, m_uintProbabilityA);
	DDV_MinMaxUInt(pDX, m_uintProbabilityA, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_B, m_uintProbabilityB);
	DDV_MinMaxUInt(pDX, m_uintProbabilityB, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_C, m_uintProbabilityC);
	DDV_MinMaxUInt(pDX, m_uintProbabilityC, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_D, m_uintProbabilityD);
	DDV_MinMaxUInt(pDX, m_uintProbabilityD, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_E, m_uintProbabilityE);
	DDV_MinMaxUInt(pDX, m_uintProbabilityE, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_F, m_uintProbabilityF);
	DDV_MinMaxUInt(pDX, m_uintProbabilityF, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_G, m_uintProbabilityG);
	DDV_MinMaxUInt(pDX, m_uintProbabilityG, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_H, m_uintProbabilityH);
	DDV_MinMaxUInt(pDX, m_uintProbabilityH, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_I, m_uintProbabilityI);
	DDV_MinMaxUInt(pDX, m_uintProbabilityI, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_J, m_uintProbabilityJ);
	DDV_MinMaxUInt(pDX, m_uintProbabilityJ, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_K, m_uintProbabilityK);
	DDV_MinMaxUInt(pDX, m_uintProbabilityK, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_L, m_uintProbabilityL);
	DDV_MinMaxUInt(pDX, m_uintProbabilityL, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_M, m_uintProbabilityM);
	DDV_MinMaxUInt(pDX, m_uintProbabilityM, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_N, m_uintProbabilityN);
	DDV_MinMaxUInt(pDX, m_uintProbabilityN, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_O, m_uintProbabilityO);
	DDV_MinMaxUInt(pDX, m_uintProbabilityO, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_P, m_uintProbabilityP);
	DDV_MinMaxUInt(pDX, m_uintProbabilityP, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_R, m_uintProbabilityR);
	DDV_MinMaxUInt(pDX, m_uintProbabilityR, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_Q, m_uintProbabilityQ);
	DDV_MinMaxUInt(pDX, m_uintProbabilityQ, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_S, m_uintProbabilityS);
	DDV_MinMaxUInt(pDX, m_uintProbabilityS, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_T, m_uintProbabilityT);
	DDV_MinMaxUInt(pDX, m_uintProbabilityT, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_U, m_uintProbabilityU);
	DDV_MinMaxUInt(pDX, m_uintProbabilityU, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_V, m_uintProbabilityV);
	DDV_MinMaxUInt(pDX, m_uintProbabilityV, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_W, m_uintProbabilityW);
	DDV_MinMaxUInt(pDX, m_uintProbabilityW, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_X, m_uintProbabilityX);
	DDV_MinMaxUInt(pDX, m_uintProbabilityX, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_Y, m_uintProbabilityY);
	DDV_MinMaxUInt(pDX, m_uintProbabilityY, 0, 32000);
	DDX_Text(pDX, IDC_EDIT_PROBABILITY_Z, m_uintProbabilityZ);
	DDV_MinMaxUInt(pDX, m_uintProbabilityZ, 0, 32000);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_A, m_strProbabilityAPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_B, m_strProbabilityBPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_C, m_strProbabilityCPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_D, m_strProbabilityDPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_E, m_strProbabilityEPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_F, m_strProbabilityFPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_G, m_strProbabilityGPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_H, m_strProbabilityHPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_I, m_strProbabilityIPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_J, m_strProbabilityJPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_K, m_strProbabilityKPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_L, m_strProbabilityLPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_M, m_strProbabilityMPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_N, m_strProbabilityNPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_O, m_strProbabilityOPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_P, m_strProbabilityPPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_Q, m_strProbabilityQPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_R, m_strProbabilityRPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_S, m_strProbabilitySPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_T, m_strProbabilityTPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_U, m_strProbabilityUPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_V, m_strProbabilityVPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_W, m_strProbabilityWPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_X, m_strProbabilityXPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_Y, m_strProbabilityYPercent);
	DDX_Text(pDX, IDC_STATIC_PROBABILITY_Z, m_strProbabilityZPercent);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CProbabilityDlg, CDialog)
	//{{AFX_MSG_MAP(CProbabilityDlg)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_A, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_B, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_C, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_D, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_E, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_F, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_G, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_H, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_I, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_J, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_K, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_L, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_M, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_N, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_O, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_P, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_Q, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_R, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_S, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_T, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_U, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_V, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_W, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_X, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_Y, OnKillfocusEditProbability)
	ON_EN_KILLFOCUS(IDC_EDIT_PROBABILITY_Z, OnKillfocusEditProbability)
	ON_BN_CLICKED(ID_BUTTON_RANDOM, OnButtonRandom)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CProbabilityDlg message handlers

void CProbabilityDlg::OnKillfocusEditProbability() 
{
  UpdateData(true);
  CProbabilityDlg::Assign();
  UpdateData(false);
}


BOOL CProbabilityDlg::OnInitDialog() 
{
  UpdateData(false);
  UpdateData(true);

  CProbabilityDlg::Assign();
  EnableThemeDialogTexture(GetSafeHwnd());
  m_uintProbabilityA_Copy = m_uintProbabilityA;
  m_uintProbabilityB_Copy = m_uintProbabilityB;
  m_uintProbabilityC_Copy = m_uintProbabilityC;
  m_uintProbabilityD_Copy = m_uintProbabilityD;
  m_uintProbabilityE_Copy = m_uintProbabilityE;
  m_uintProbabilityF_Copy = m_uintProbabilityF;
  m_uintProbabilityG_Copy = m_uintProbabilityG;
  m_uintProbabilityH_Copy = m_uintProbabilityH;
  m_uintProbabilityI_Copy = m_uintProbabilityI;
  m_uintProbabilityJ_Copy = m_uintProbabilityJ;
  m_uintProbabilityK_Copy = m_uintProbabilityK;
  m_uintProbabilityL_Copy = m_uintProbabilityL;
  m_uintProbabilityM_Copy = m_uintProbabilityM;
  m_uintProbabilityN_Copy = m_uintProbabilityN;
  m_uintProbabilityO_Copy = m_uintProbabilityO;
  m_uintProbabilityP_Copy = m_uintProbabilityP;
  m_uintProbabilityR_Copy = m_uintProbabilityQ;
  m_uintProbabilityQ_Copy = m_uintProbabilityR;
  m_uintProbabilityS_Copy = m_uintProbabilityS;
  m_uintProbabilityT_Copy = m_uintProbabilityT;
  m_uintProbabilityU_Copy = m_uintProbabilityU;
  m_uintProbabilityV_Copy = m_uintProbabilityV;
  m_uintProbabilityW_Copy = m_uintProbabilityW;
  m_uintProbabilityX_Copy = m_uintProbabilityX;
  m_uintProbabilityY_Copy = m_uintProbabilityY;
  m_uintProbabilityZ_Copy = m_uintProbabilityZ;

  m_btnOK.SetThemeHelper(&m_ThemeHelper);
  m_btnOK.SetIcon(IDI_ICON_OK);
  m_btnOK.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnOK.DrawFlatFocus(true);
  m_btnOK.SetTooltipText("Click to accept the actual\ncharacter frequencies");

  m_btnCancel.SetThemeHelper(&m_ThemeHelper);
  m_btnCancel.SetIcon(IDI_ICON_CANCEL);
  m_btnCancel.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnCancel.DrawFlatFocus(true);
  m_btnCancel.SetTooltipText("Click to cancel the latest changes");

  m_btnRandom.SetThemeHelper(&m_ThemeHelper);
  m_btnRandom.SetIcon(IDI_ICON_RANDOM);
  m_btnRandom.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnRandom.DrawFlatFocus(true);
  m_btnRandom.SetTooltipText("Click to load random character frequencies");

  UpdateData(false);

  CDialog::OnInitDialog();
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CProbabilityDlg::OnCancel()
{ 
  UpdateData(true);

  m_uintProbabilityA = m_uintProbabilityA_Copy;
  m_uintProbabilityB = m_uintProbabilityB_Copy;
  m_uintProbabilityC = m_uintProbabilityC_Copy;
  m_uintProbabilityD = m_uintProbabilityD_Copy;
  m_uintProbabilityE = m_uintProbabilityE_Copy;
  m_uintProbabilityF = m_uintProbabilityF_Copy;
  m_uintProbabilityG = m_uintProbabilityG_Copy;
  m_uintProbabilityH = m_uintProbabilityH_Copy;
  m_uintProbabilityI = m_uintProbabilityI_Copy;
  m_uintProbabilityJ = m_uintProbabilityJ_Copy;
  m_uintProbabilityK = m_uintProbabilityK_Copy;
  m_uintProbabilityL = m_uintProbabilityL_Copy;
  m_uintProbabilityM = m_uintProbabilityM_Copy;
  m_uintProbabilityN = m_uintProbabilityN_Copy;
  m_uintProbabilityO = m_uintProbabilityO_Copy;
  m_uintProbabilityP = m_uintProbabilityP_Copy;
  m_uintProbabilityR = m_uintProbabilityQ_Copy;
  m_uintProbabilityQ = m_uintProbabilityR_Copy;
  m_uintProbabilityS = m_uintProbabilityS_Copy;
  m_uintProbabilityT = m_uintProbabilityT_Copy;
  m_uintProbabilityU = m_uintProbabilityU_Copy;
  m_uintProbabilityV = m_uintProbabilityV_Copy;
  m_uintProbabilityW = m_uintProbabilityW_Copy;
  m_uintProbabilityX = m_uintProbabilityX_Copy;
  m_uintProbabilityY = m_uintProbabilityY_Copy;
  m_uintProbabilityZ = m_uintProbabilityZ_Copy;

  CProbabilityDlg::Assign();
    
  UpdateData(false);
	CDialog::OnCancel();
}

void CProbabilityDlg::OnButtonRandom() 
{
  m_uintProbabilityA = rand() % 100;
  m_uintProbabilityB = rand() % 100;
  m_uintProbabilityC = rand() % 100;
  m_uintProbabilityD = rand() % 100;
  m_uintProbabilityE = rand() % 100;
  m_uintProbabilityF = rand() % 100;
  m_uintProbabilityG = rand() % 100;
  m_uintProbabilityH = rand() % 100;
  m_uintProbabilityI = rand() % 100;
  m_uintProbabilityJ = rand() % 100;
  m_uintProbabilityK = rand() % 100;
  m_uintProbabilityL = rand() % 100;
  m_uintProbabilityM = rand() % 100;
  m_uintProbabilityN = rand() % 100;
  m_uintProbabilityO = rand() % 100;
  m_uintProbabilityP = rand() % 100;
  m_uintProbabilityR = rand() % 100;
  m_uintProbabilityQ = rand() % 100;
  m_uintProbabilityS = rand() % 100;
  m_uintProbabilityT = rand() % 100;
  m_uintProbabilityU = rand() % 100;
  m_uintProbabilityV = rand() % 100;
  m_uintProbabilityW = rand() % 100;
  m_uintProbabilityX = rand() % 100;
  m_uintProbabilityY = rand() % 100;
  m_uintProbabilityZ = rand() % 100;

  CProbabilityDlg::Assign();

  UpdateData(false);
}

void CProbabilityDlg::Assign()
{
  CString strPercent = " %";
  m_uintSumOfCharacters = 0;

  m_uintSumOfCharacters += m_uintProbabilityA;
  m_uintSumOfCharacters += m_uintProbabilityB;
  m_uintSumOfCharacters += m_uintProbabilityC;
  m_uintSumOfCharacters += m_uintProbabilityD;
  m_uintSumOfCharacters += m_uintProbabilityE;
  m_uintSumOfCharacters += m_uintProbabilityF;
  m_uintSumOfCharacters += m_uintProbabilityG;
  m_uintSumOfCharacters += m_uintProbabilityH;
  m_uintSumOfCharacters += m_uintProbabilityI;
  m_uintSumOfCharacters += m_uintProbabilityJ;
  m_uintSumOfCharacters += m_uintProbabilityK;
  m_uintSumOfCharacters += m_uintProbabilityL;
  m_uintSumOfCharacters += m_uintProbabilityM;
  m_uintSumOfCharacters += m_uintProbabilityN;
  m_uintSumOfCharacters += m_uintProbabilityO;
  m_uintSumOfCharacters += m_uintProbabilityP;
  m_uintSumOfCharacters += m_uintProbabilityQ;
  m_uintSumOfCharacters += m_uintProbabilityR;
  m_uintSumOfCharacters += m_uintProbabilityS;
  m_uintSumOfCharacters += m_uintProbabilityT;
  m_uintSumOfCharacters += m_uintProbabilityU;
  m_uintSumOfCharacters += m_uintProbabilityV;
  m_uintSumOfCharacters += m_uintProbabilityW;
  m_uintSumOfCharacters += m_uintProbabilityX;
  m_uintSumOfCharacters += m_uintProbabilityY;
  m_uintSumOfCharacters += m_uintProbabilityZ;

  m_fProbabilityARelative = static_cast<float>(100*m_uintProbabilityA)/m_uintSumOfCharacters;
  m_fProbabilityBRelative = static_cast<float>(100*m_uintProbabilityB)/m_uintSumOfCharacters;
  m_fProbabilityCRelative = static_cast<float>(100*m_uintProbabilityC)/m_uintSumOfCharacters;
  m_fProbabilityDRelative = static_cast<float>(100*m_uintProbabilityD)/m_uintSumOfCharacters;
  m_fProbabilityERelative = static_cast<float>(100*m_uintProbabilityE)/m_uintSumOfCharacters;
  m_fProbabilityFRelative = static_cast<float>(100*m_uintProbabilityF)/m_uintSumOfCharacters;
  m_fProbabilityGRelative = static_cast<float>(100*m_uintProbabilityG)/m_uintSumOfCharacters;
  m_fProbabilityHRelative = static_cast<float>(100*m_uintProbabilityH)/m_uintSumOfCharacters;
  m_fProbabilityIRelative = static_cast<float>(100*m_uintProbabilityI)/m_uintSumOfCharacters;
  m_fProbabilityJRelative = static_cast<float>(100*m_uintProbabilityJ)/m_uintSumOfCharacters;
  m_fProbabilityKRelative = static_cast<float>(100*m_uintProbabilityK)/m_uintSumOfCharacters;
  m_fProbabilityLRelative = static_cast<float>(100*m_uintProbabilityL)/m_uintSumOfCharacters;
  m_fProbabilityMRelative = static_cast<float>(100*m_uintProbabilityM)/m_uintSumOfCharacters;
  m_fProbabilityNRelative = static_cast<float>(100*m_uintProbabilityN)/m_uintSumOfCharacters;
  m_fProbabilityORelative = static_cast<float>(100*m_uintProbabilityO)/m_uintSumOfCharacters;
  m_fProbabilityPRelative = static_cast<float>(100*m_uintProbabilityP)/m_uintSumOfCharacters;
  m_fProbabilityQRelative = static_cast<float>(100*m_uintProbabilityQ)/m_uintSumOfCharacters;
  m_fProbabilityRRelative = static_cast<float>(100*m_uintProbabilityR)/m_uintSumOfCharacters;
  m_fProbabilitySRelative = static_cast<float>(100*m_uintProbabilityS)/m_uintSumOfCharacters;
  m_fProbabilityTRelative = static_cast<float>(100*m_uintProbabilityT)/m_uintSumOfCharacters;
  m_fProbabilityURelative = static_cast<float>(100*m_uintProbabilityU)/m_uintSumOfCharacters;
  m_fProbabilityVRelative = static_cast<float>(100*m_uintProbabilityV)/m_uintSumOfCharacters;
  m_fProbabilityWRelative = static_cast<float>(100*m_uintProbabilityW)/m_uintSumOfCharacters;
  m_fProbabilityXRelative = static_cast<float>(100*m_uintProbabilityX)/m_uintSumOfCharacters;
  m_fProbabilityYRelative = static_cast<float>(100*m_uintProbabilityY)/m_uintSumOfCharacters;
  m_fProbabilityZRelative = static_cast<float>(100*m_uintProbabilityZ)/m_uintSumOfCharacters;

  m_strProbabilityAPercent.Format("%.2f",m_fProbabilityARelative);
  m_strProbabilityBPercent.Format("%.2f",m_fProbabilityBRelative);
  m_strProbabilityCPercent.Format("%.2f",m_fProbabilityCRelative);
  m_strProbabilityDPercent.Format("%.2f",m_fProbabilityDRelative);
  m_strProbabilityEPercent.Format("%.2f",m_fProbabilityERelative);
  m_strProbabilityFPercent.Format("%.2f",m_fProbabilityFRelative);
  m_strProbabilityGPercent.Format("%.2f",m_fProbabilityGRelative);
  m_strProbabilityHPercent.Format("%.2f",m_fProbabilityHRelative);
  m_strProbabilityIPercent.Format("%.2f",m_fProbabilityIRelative);
  m_strProbabilityJPercent.Format("%.2f",m_fProbabilityJRelative);
  m_strProbabilityKPercent.Format("%.2f",m_fProbabilityKRelative);
  m_strProbabilityLPercent.Format("%.2f",m_fProbabilityLRelative);
  m_strProbabilityMPercent.Format("%.2f",m_fProbabilityMRelative);
  m_strProbabilityNPercent.Format("%.2f",m_fProbabilityNRelative);
  m_strProbabilityOPercent.Format("%.2f",m_fProbabilityORelative);
  m_strProbabilityPPercent.Format("%.2f",m_fProbabilityPRelative);
  m_strProbabilityQPercent.Format("%.2f",m_fProbabilityQRelative);
  m_strProbabilityRPercent.Format("%.2f",m_fProbabilityRRelative);
  m_strProbabilitySPercent.Format("%.2f",m_fProbabilitySRelative);
  m_strProbabilityTPercent.Format("%.2f",m_fProbabilityTRelative);
  m_strProbabilityUPercent.Format("%.2f",m_fProbabilityURelative);
  m_strProbabilityVPercent.Format("%.2f",m_fProbabilityVRelative);
  m_strProbabilityWPercent.Format("%.2f",m_fProbabilityWRelative);
  m_strProbabilityXPercent.Format("%.2f",m_fProbabilityXRelative);
  m_strProbabilityYPercent.Format("%.2f",m_fProbabilityYRelative);
  m_strProbabilityZPercent.Format("%.2f",m_fProbabilityZRelative);

  m_strProbabilityAPercent += strPercent;
  m_strProbabilityBPercent += strPercent;
  m_strProbabilityCPercent += strPercent;
  m_strProbabilityDPercent += strPercent;
  m_strProbabilityEPercent += strPercent;
  m_strProbabilityFPercent += strPercent;
  m_strProbabilityGPercent += strPercent;
  m_strProbabilityHPercent += strPercent;
  m_strProbabilityIPercent += strPercent;
  m_strProbabilityJPercent += strPercent;
  m_strProbabilityKPercent += strPercent;
  m_strProbabilityLPercent += strPercent;
  m_strProbabilityMPercent += strPercent;
  m_strProbabilityNPercent += strPercent;
  m_strProbabilityOPercent += strPercent;
  m_strProbabilityPPercent += strPercent;
  m_strProbabilityQPercent += strPercent;
  m_strProbabilityRPercent += strPercent;
  m_strProbabilitySPercent += strPercent;
  m_strProbabilityTPercent += strPercent;
  m_strProbabilityUPercent += strPercent;
  m_strProbabilityVPercent += strPercent;
  m_strProbabilityWPercent += strPercent;
  m_strProbabilityXPercent += strPercent;
  m_strProbabilityYPercent += strPercent;
  m_strProbabilityZPercent += strPercent;
}
