#if !defined(AFX_CExportDlg_H__6A53B2E2_494C_48C9_BB42_44A203F7B903__INCLUDED_)
#define AFX_CExportDlg_H__6A53B2E2_494C_48C9_BB42_44A203F7B903__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// CExportDlg.h : header file
//

#include "XPStyleButtonST.h"
#include "ThemeHelperST.h"
#include "HyperLink.h"

/////////////////////////////////////////////////////////////////////////////
// CExportDlg dialog

class CExportDlg : public CDialog
{
// Construction
public:
	CString m_strGeneratedNames;
	CExportDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CExportDlg)
	enum { IDD = IDD_DIALOG_EXPORT };
  CThemeHelperST m_ThemeHelper;
	CXPStyleButtonST m_btnCancel;
	CXPStyleButtonST m_btnExport;
	int		m_rbtnExportFormat;
	BOOL	m_cbtnExportCreator;
	BOOL	m_cbtnExportLinefeeds;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CExportDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CExportDlg)
	afx_msg void OnButtonExport();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

void	EnableThemeDialogTexture(HWND hwndDlg);

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_CExportDlg_H__6A53B2E2_494C_48C9_BB42_44A203F7B903__INCLUDED_)
