// CExportDlg.cpp : implementation file
//

#include "stdafx.h"
#include "yarng.h"
#include "ExportDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CExportDlg dialog


CExportDlg::CExportDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CExportDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CExportDlg)
	m_rbtnExportFormat = -1;
	m_cbtnExportCreator = FALSE;
	m_cbtnExportLinefeeds = FALSE;
	//}}AFX_DATA_INIT
}


void CExportDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CExportDlg)
	DDX_Control(pDX, IDCANCEL, m_btnCancel);
	DDX_Control(pDX, IDC_BUTTON_EXPORT, m_btnExport);
	DDX_Radio(pDX, IDC_RADIO_EXPORT_TXT, m_rbtnExportFormat);
	DDX_Check(pDX, IDC_CHECK_EXPORT_CREATOR, m_cbtnExportCreator);
	DDX_Check(pDX, IDC_CHECK_EXPORT_LINEFEEDS, m_cbtnExportLinefeeds);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CExportDlg, CDialog)
	//{{AFX_MSG_MAP(CExportDlg)
	ON_BN_CLICKED(IDC_BUTTON_EXPORT, OnButtonExport)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CExportDlg message handlers

void CExportDlg::OnButtonExport() 
{
  CString strFilter = "", strFileExtension = "", strID = "";
  UpdateData(true);
  switch (m_rbtnExportFormat)
  {
    case 0 : {strFilter = "Textdateien (*.txt)|*.txt|"; strFileExtension = ".txt"; break;}
    case 1 : {strFilter = "Comma-seperated value (*.csv)|*.csv|"; strFileExtension = ".csv"; break;}
    case 2 : {strFilter = "Hypertext Document (*.html)|*.html|"; strFileExtension = ".html"; break;}
    case 3 : {strFilter = "Sylk (*.slk)|*.slk|"; strFileExtension = ".slk"; break;}
  }
  strFilter += "Alle Dateien (*.*)|*.*|";
  CFileDialog dlgExportFile(false,NULL,NULL,OFN_FILEMUSTEXIST | OFN_HIDEREADONLY,strFilter,NULL);
  CString strExportFilename,strCreation;
  CTime Time;
  int nResult = dlgExportFile.DoModal();
  if (nResult == IDOK)
  {
    strExportFilename = dlgExportFile.GetPathName()+strFileExtension;
    CFile ExportFile;
    if (ExportFile.Open(LPCTSTR(strExportFilename), CFile::modeCreate | CFile::modeWrite))
    {
      switch (m_rbtnExportFormat)
      {
        case 0 : //TXT
        {
          if (!m_cbtnExportLinefeeds)
          {
            m_strGeneratedNames.Replace("\x0D\x0A",NULL);
          }
          if (m_cbtnExportCreator)
          {
            Time = CTime::GetCurrentTime();
            strCreation += "This file was created by ";
            strID.LoadString(IDS_PRODUCTNAME);
            strCreation += strID+" ";
            strID.LoadString(IDS_PRODUCTVERSION);
            strCreation += strID+" on ";
            strCreation += Time.Format("%y-%m-%d %H:%M:%S")+".\x0D\x0A\x0D\x0A";
            m_strGeneratedNames = strCreation+m_strGeneratedNames;
          }
          break;
        }
        case 1 : //CSV
        {
          if (m_cbtnExportLinefeeds)
          {
            m_strGeneratedNames.Remove(' ');
            m_strGeneratedNames.Replace(",",";");
            m_strGeneratedNames.Replace(";","\";");
            m_strGeneratedNames.Replace("\x0D\x0A","\x0D\x0A\"");
            m_strGeneratedNames = "\""+m_strGeneratedNames+"\"";
          } else {
            m_strGeneratedNames.Replace("\x0D\x0A",NULL);
            m_strGeneratedNames = "\""+m_strGeneratedNames+"\";";
          }
          if (m_cbtnExportCreator)
          {
            Time = CTime::GetCurrentTime();
            strCreation += "\"This file was created by ";
            strID.LoadString(IDS_PRODUCTNAME);
            strCreation += strID+" ";
            strID.LoadString(IDS_PRODUCTVERSION);
            strCreation += strID+" on ";
            strCreation += Time.Format("%y-%m-%d %H:%M:%S")+".\";\x0D\x0A\"\";\x0D\x0A";
            m_strGeneratedNames = strCreation+m_strGeneratedNames;
          }
          break;
        }
        case 2 : //HTML
        {
          if (m_cbtnExportLinefeeds)
          {
            m_strGeneratedNames.Replace(",",",<br />");
          } else {
            m_strGeneratedNames.Replace("\x0D\x0A",NULL);
          }
          if (m_cbtnExportCreator)
          {
            Time = CTime::GetCurrentTime();
            strCreation += "This file was created by ";
            strID.LoadString(IDS_PRODUCTNAME);
            strCreation += strID+" ";
            strID.LoadString(IDS_PRODUCTVERSION);
            strCreation += strID+" on ";
            strCreation += Time.Format("%y-%m-%d %H:%M:%S")+".<br /><br />";
            m_strGeneratedNames = strCreation+m_strGeneratedNames;
          }
          break;
        }
        case 3 : //SLK
        {
          int nY = 1, nIndex = 0;
          if (m_cbtnExportCreator) nY += 2;
          CString strInsert;
          bool bFinished = false;
          if (m_cbtnExportLinefeeds)
          {
            m_strGeneratedNames.Replace(", ",NULL);
            m_strGeneratedNames = "ID;PSCALC3\x0D\x0A"+m_strGeneratedNames;
            m_strGeneratedNames.Replace("\x0D\x0A","\"\x0D\x0A_\"");
            do
            {
              if (m_strGeneratedNames.GetAt(nIndex) == '_')
              {
                strInsert.Format("%d",nY);
                strInsert = "C;X1;Y"+strInsert+";K";
                m_strGeneratedNames.Insert(nIndex,strInsert);
                nY++;
              }
              nIndex += strInsert.GetLength();
              nIndex++;
              strInsert.Empty();
              bFinished = nIndex >= m_strGeneratedNames.GetLength();
            } while (!bFinished);
            m_strGeneratedNames.Remove('_');
            m_strGeneratedNames += "\"\x0D\x0A";
            m_strGeneratedNames += "E";
            m_strGeneratedNames.Replace("ID;PSCALC3\"","ID;PSCALC3");
          } else {
            m_strGeneratedNames.Replace("\x0D\x0A",NULL);
            strInsert.Format("%d",nY);
            strInsert = "C;X1;Y"+strInsert+";K\"";            
            m_strGeneratedNames = strInsert+m_strGeneratedNames;
            m_strGeneratedNames = "ID;PSCALC3\x0D\x0A"+m_strGeneratedNames;
            m_strGeneratedNames += "\"\x0D\x0A";
            m_strGeneratedNames += "E";
          }
          if (m_cbtnExportCreator)
          {
            Time = CTime::GetCurrentTime();
            strCreation += "C;X1;Y1;K\"This file was created by ";
            strID.LoadString(IDS_PRODUCTNAME);
            strCreation += strID+" ";
            strID.LoadString(IDS_PRODUCTVERSION);
            strCreation += strID+" on ";
            strCreation += Time.Format("%y-%m-%d %H:%M:%S")+".\"\x0D\x0A";
            strCreation += "C;X1;Y2;K\"\"\x0D\x0A";
            m_strGeneratedNames.Replace("ID;PSCALC3\x0D\x0A","ID;PSCALC3\x0D\x0A"+strCreation);
          }
          break;
        }
      }
      ExportFile.Write(m_strGeneratedNames,m_strGeneratedNames.GetLength());
      ExportFile.Close();
      EndDialog(IDOK);
      MessageBox("File successfully exported!","Export",MB_OK + MB_ICONINFORMATION);
    } else { MessageBox("File couldn't be created!","Error!!!",MB_OK + MB_ICONSTOP); }
  }
}

BOOL CExportDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
  EnableThemeDialogTexture(GetSafeHwnd());
  m_btnExport.SetThemeHelper(&m_ThemeHelper);
  m_btnExport.SetIcon(IDI_ICON_EXPORT);
  m_btnExport.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnExport.DrawFlatFocus(true);
  m_btnExport.SetTooltipText("Export the list with the random names");
  m_btnCancel.SetThemeHelper(&m_ThemeHelper);
  m_btnCancel.SetIcon(IDI_ICON_CANCEL);
  m_btnCancel.OffsetColor(CButtonST::BTNST_COLOR_BK_IN,100);
  m_btnCancel.DrawFlatFocus(true);
  m_btnCancel.SetTooltipText("Cancel the export");
  m_rbtnExportFormat = 0;
  m_cbtnExportLinefeeds = true;
  m_cbtnExportCreator = true;
  UpdateData(false);
	return TRUE; 
}
