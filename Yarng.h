// Yarng.h : main header file for the YARNG application
//

#if !defined(AFX_YARNG_H__DDF64A97_7BDC_4503_ABC3_6633EF95A42B__INCLUDED_)
#define AFX_YARNG_H__DDF64A97_7BDC_4503_ABC3_6633EF95A42B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CYarngApp:
// See Yarng.cpp for the implementation of this class
//

class CYarngApp : public CWinApp
{
public:
	CYarngApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CYarngApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CYarngApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_YARNG_H__DDF64A97_7BDC_4503_ABC3_6633EF95A42B__INCLUDED_)
