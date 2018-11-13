// YarngDlg.h : header file
//

#if !defined(AFX_YARNGDLG_H__F39E520E_AB25_4C36_B18E_6D381518089C__INCLUDED_)
#define AFX_YARNGDLG_H__F39E520E_AB25_4C36_B18E_6D381518089C__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "XPStyleButtonST.h"
#include "ThemeHelperST.h"
#include "HyperLink.h"

/////////////////////////////////////////////////////////////////////////////
// CYarngDlg dialog

class CYarngDlg : public CDialog
{
// Construction
public:
	CString m_strCharacters;
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
	UINT m_uintProbabilityQ;
	UINT m_uintProbabilityR;
	UINT m_uintProbabilityS;
	UINT m_uintProbabilityT;
	UINT m_uintProbabilityU;
	UINT m_uintProbabilityV;
	UINT m_uintProbabilityW;
	UINT m_uintProbabilityX;
	UINT m_uintProbabilityY;
	UINT m_uintProbabilityZ;
	

	CYarngDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CYarngDlg)
	enum { IDD = IDD_YARNG_DIALOG };
	CProgressCtrl	m_prgsGenerate;
	CXPStyleButtonST	m_btnPrint;
	CXPStyleButtonST	m_btnClipboard;
	CXPStyleButtonST	m_btnExport;
	CXPStyleButtonST	m_btnClear;
	CXPStyleButtonST	m_btnLoad;
	CXPStyleButtonST	m_btnSave;
	CXPStyleButtonST	m_btnProbabilityTable;
	CXPStyleButtonST	m_btnHowto;
	CXPStyleButtonST	m_btnHistory;
	CXPStyleButtonST	m_btnDefaultSettings;
	CXPStyleButtonST	m_btnAbout;
	CXPStyleButtonST	m_btnExit;
	CXPStyleButtonST	m_btnGenerate;
  CThemeHelperST m_ThemeHelper;
	CComboBox	m_cmbLanguage;
	CString	m_strGeneratedNames;
	UINT		m_uintLanguage;
  CUIntArray m_uintLanguageXX;
	int		m_nLengthOfNamesMax;
	int		m_nLengthOfNamesMin;
	int		m_nNumberOfNames;
	CString	m_strConsonants;
	CString	m_strVowels;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CYarngDlg)
	public:
	virtual BOOL PreTranslateMessage(MSG* pMsg);
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation

private:
	CStatusBar m_StatusBar;


protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CYarngDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnButtonGenerate();
	afx_msg void OnButtonHistory();
	afx_msg void OnButtonAbout();
	afx_msg void OnButtonExit();
	afx_msg void OnButtonHowto();
	afx_msg void OnButtonDefaultSettings();
	afx_msg void OnButtonProbabilityTable();
	afx_msg void OnSelchangeComboLanguage();
	afx_msg void OnButtonLngLoad();
	afx_msg void OnButtonLngSave();
	afx_msg void OnButtonClear();
	afx_msg void OnButtonCopy();
	afx_msg void OnButtonExport();
	afx_msg void OnButtonPrint();
	afx_msg void OnTimer(UINT nIDEvent);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_YARNGDLG_H__F39E520E_AB25_4C36_B18E_6D381518089C__INCLUDED_)
