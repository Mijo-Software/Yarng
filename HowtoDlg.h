#if !defined(AFX_HOWTO_H__ECC40D93_4D1C_433A_94F2_C2FDDD63903F__INCLUDED_)
#define AFX_HOWTO_H__ECC40D93_4D1C_433A_94F2_C2FDDD63903F__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Howto.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CHowtoDlg dialog

class CHowtoDlg : public CDialog
{
// Construction
public:
	CHowtoDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CHowtoDlg)
	enum { IDD = IDD_DIALOG_HOWTO };
	CString	m_strHowTo;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CHowtoDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CHowtoDlg)
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

void	EnableThemeDialogTexture(HWND hwndDlg);

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_HOWTO_H__ECC40D93_4D1C_433A_94F2_C2FDDD63903F__INCLUDED_)
