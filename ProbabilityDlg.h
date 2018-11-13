#if !defined(AFX_PROBABILITYDLG_H__9B4EB0A1_CA49_4CF9_BACC_1B1BE04499AE__INCLUDED_)
#define AFX_PROBABILITYDLG_H__9B4EB0A1_CA49_4CF9_BACC_1B1BE04499AE__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// ProbabilityDlg.h : header file
//

#include "XPStyleButtonST.h"
#include "ThemeHelperST.h"
#include "HyperLink.h"

/////////////////////////////////////////////////////////////////////////////
// CProbabilityDlg dialog

class CProbabilityDlg : public CDialog
{
// Construction
public:
	UINT m_uintSumOfCharacters;
	CProbabilityDlg(CWnd* pParent = NULL);   // standard constructor
  
  // Dialog Data
	//{{AFX_DATA(CProbabilityDlg)
	enum { IDD = IDD_DIALOG_PROBABILITY };
	CXPStyleButtonST	m_btnOK;
	CXPStyleButtonST	m_btnCancel;
	CXPStyleButtonST	m_btnRandom;
  CThemeHelperST m_ThemeHelper;
	UINT m_uintProbabilityA; 
	UINT m_uintProbabilityB;
	UINT m_uintProbabilityC;
	UINT m_uintProbabilityD;
	UINT m_uintProbabilityE;
	UINT m_uintProbabilityF;
	UINT m_uintProbabilityG;
	UINT m_uintProbabilityH;
	UINT m_uintProbabilityI;
	UINT m_uintProbabilityJ;
	UINT m_uintProbabilityK;
	UINT m_uintProbabilityL;
	UINT m_uintProbabilityM;
	UINT m_uintProbabilityN;
	UINT m_uintProbabilityO;
	UINT m_uintProbabilityP;
	UINT m_uintProbabilityR;
	UINT m_uintProbabilityQ;
	UINT m_uintProbabilityS;
	UINT m_uintProbabilityT;
	UINT m_uintProbabilityU;
	UINT m_uintProbabilityV;
	UINT m_uintProbabilityW;
	UINT m_uintProbabilityX;
	UINT m_uintProbabilityY;
	UINT m_uintProbabilityZ;
	UINT m_uintProbabilityA_Copy;
	UINT m_uintProbabilityB_Copy;
	UINT m_uintProbabilityC_Copy;
	UINT m_uintProbabilityD_Copy;
	UINT m_uintProbabilityE_Copy;
	UINT m_uintProbabilityF_Copy;
	UINT m_uintProbabilityG_Copy;
	UINT m_uintProbabilityH_Copy;
	UINT m_uintProbabilityI_Copy;
	UINT m_uintProbabilityJ_Copy;
	UINT m_uintProbabilityK_Copy;
	UINT m_uintProbabilityL_Copy;
	UINT m_uintProbabilityM_Copy;
	UINT m_uintProbabilityN_Copy;
	UINT m_uintProbabilityO_Copy;
	UINT m_uintProbabilityP_Copy;
	UINT m_uintProbabilityR_Copy;
	UINT m_uintProbabilityQ_Copy;
	UINT m_uintProbabilityS_Copy;
	UINT m_uintProbabilityT_Copy;
	UINT m_uintProbabilityU_Copy;
	UINT m_uintProbabilityV_Copy;
	UINT m_uintProbabilityW_Copy;
	UINT m_uintProbabilityX_Copy;
	UINT m_uintProbabilityY_Copy;
	UINT m_uintProbabilityZ_Copy;
  float m_fProbabilityARelative;
  float m_fProbabilityBRelative;
  float m_fProbabilityCRelative;
  float m_fProbabilityDRelative;
  float m_fProbabilityERelative;
  float m_fProbabilityFRelative;
  float m_fProbabilityGRelative;
  float m_fProbabilityHRelative;
  float m_fProbabilityIRelative;
  float m_fProbabilityJRelative;
  float m_fProbabilityKRelative;
  float m_fProbabilityLRelative;
  float m_fProbabilityMRelative;
  float m_fProbabilityNRelative;
  float m_fProbabilityORelative;
  float m_fProbabilityPRelative;
  float m_fProbabilityQRelative;
  float m_fProbabilityRRelative;
  float m_fProbabilitySRelative;
  float m_fProbabilityTRelative;
  float m_fProbabilityURelative;
  float m_fProbabilityVRelative;
  float m_fProbabilityWRelative;
  float m_fProbabilityXRelative;
  float m_fProbabilityYRelative;
  float m_fProbabilityZRelative;
	CString	m_strProbabilityAPercent;
	CString	m_strProbabilityBPercent;
	CString	m_strProbabilityCPercent;
	CString	m_strProbabilityDPercent;
	CString	m_strProbabilityEPercent;
	CString	m_strProbabilityFPercent;
	CString	m_strProbabilityGPercent;
	CString	m_strProbabilityHPercent;
	CString	m_strProbabilityIPercent;
	CString	m_strProbabilityJPercent;
	CString	m_strProbabilityKPercent;
	CString	m_strProbabilityLPercent;
	CString	m_strProbabilityMPercent;
	CString	m_strProbabilityNPercent;
	CString	m_strProbabilityOPercent;
	CString	m_strProbabilityPPercent;
	CString	m_strProbabilityQPercent;
	CString	m_strProbabilityRPercent;
	CString	m_strProbabilitySPercent;
	CString	m_strProbabilityTPercent;
	CString	m_strProbabilityUPercent;
	CString	m_strProbabilityVPercent;
	CString	m_strProbabilityWPercent;
	CString	m_strProbabilityXPercent;
	CString	m_strProbabilityYPercent;
	CString	m_strProbabilityZPercent;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CProbabilityDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	void Assign();

	// Generated message map functions
	//{{AFX_MSG(CProbabilityDlg)
	afx_msg void OnKillfocusEditProbability();
	virtual BOOL OnInitDialog();
	virtual void OnCancel();
	afx_msg void OnButtonRandom();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

void	EnableThemeDialogTexture(HWND hwndDlg);

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PROBABILITYDLG_H__9B4EB0A1_CA49_4CF9_BACC_1B1BE04499AE__INCLUDED_)
