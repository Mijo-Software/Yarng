// Howto.cpp : implementation file
//

#include "stdafx.h"
#include "Yarng.h"
#include "HowtoDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CHowtoDlg dialog


CHowtoDlg::CHowtoDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CHowtoDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CHowtoDlg)
	m_strHowTo = _T("");
	//}}AFX_DATA_INIT
  m_strHowTo = "How to generate random names\x0D\x0A==========================\x0D\x0A\x0D\x0A";
  m_strHowTo += "Yarng uses a very easy algorithm. It \x0D\x0A";
  m_strHowTo += "is based on a constant change between \x0D\x0A";
  m_strHowTo += "consonants (c) and vowels (v), e. g. \x0D\x0A";
  m_strHowTo += "cvcvc... or vcvcvc... \x0D\x0A\x0D\x0A";
  m_strHowTo += "All consonants and vowels are random \x0D\x0A";
  m_strHowTo += "character between A...Z. The conso- \x0D\x0A";
  m_strHowTo += "nants and vowels create then a name. \x0D\x0A";
  m_strHowTo += "Either this name can have a fixed \x0D\x0A";
  m_strHowTo += "character length or a random chara- \x0D\x0A";
  m_strHowTo += "cter length. \x0D\x0A\x0D\x0A";
  m_strHowTo += "Some examples \x0D\x0A";                 
  m_strHowTo += "* Lopuq (form: cvcvc) \x0D\x0A";
  m_strHowTo += "* Uhiwirupas (form: vcvcvcvcvc) \x0D\x0A";
  m_strHowTo += "* Ikotajaq (form: vcvcvcvc) \x0D\x0A";
  m_strHowTo += "* Kuvo (form: cvcv) \x0D\x0A";
  m_strHowTo += "* Iciyoliri (form: vcvcvcvcv) \x0D\x0A\x0D\x0A";
  m_strHowTo += "Of course Yarng can change the chara-\x0D\x0A";
  m_strHowTo += "cter frequencies. Either you can \x0D\x0A";
  m_strHowTo += "input the character frequencies by \x0D\x0A";
  m_strHowTo += "hand or you can choose a template, \x0D\x0A";
  m_strHowTo += "which contains the character fre- \x0D\x0A";
  m_strHowTo += "quencies of some european language. \x0D\x0A";
}


void CHowtoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CHowtoDlg)
	DDX_Text(pDX, IDC_EDIT_HOWTO, m_strHowTo);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CHowtoDlg, CDialog)
	//{{AFX_MSG_MAP(CHowtoDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CHowtoDlg message handlers

BOOL CHowtoDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
  EnableThemeDialogTexture(GetSafeHwnd());
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
