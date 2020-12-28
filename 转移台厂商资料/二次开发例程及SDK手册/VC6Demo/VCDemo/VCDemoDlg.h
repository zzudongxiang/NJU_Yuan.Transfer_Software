// VCDemoDlg.h : header file
//

#if !defined(AFX_VCDEMODLG_H__4ADF9A84_50C7_4723_9948_5329D4B03CCF__INCLUDED_)
#define AFX_VCDEMODLG_H__4ADF9A84_50C7_4723_9948_5329D4B03CCF__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CVCDemoDlg dialog

class CVCDemoDlg : public CDialog
{
// Construction
public:
	CVCDemoDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CVCDemoDlg)
	enum { IDD = IDD_VCDEMO_DIALOG };
	CButton	m_Neg;
	CButton	m_Pos;
	CButton	m_Zero;
	CButton	m_Run;
	CButton	m_Dir;
	CEdit	m_V_Now;
	CEdit	m_Timer;
	CEdit	m_Axis;
	CEdit	m_In;
	CEdit	m_Out;
	CEdit	m_P_Now;
	CEdit	m_Home_V;
	CEdit	m_V_Abs;
	CEdit	m_V_Ref;
	CEdit	m_Ref;
	CEdit	m_Port;
	CEdit	m_Maxv;
	CEdit	m_Dec;
	CEdit	m_Acc;
	CEdit	m_Abs;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CVCDemoDlg)
	public:
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CVCDemoDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnButton1();
	afx_msg void OnBtnAcc();
	afx_msg void OnBtnDec();
	afx_msg void OnBtnMaxv();
	afx_msg void OnBtnRef();
	afx_msg void OnBtnAbs();
	afx_msg void OnStop();
	afx_msg void OnHalt();
	afx_msg void OnBtnVRef();
	afx_msg void OnBtnVAbs();
	afx_msg void OnStopV();
	afx_msg void OnBtnHome();
	afx_msg void OnStopHome();
	afx_msg void OnBtnIn();
	afx_msg void OnBtnOut();
	afx_msg void OnBtnCheck2();
	afx_msg void OnClose();
	afx_msg void OnBtnStatus();
	afx_msg void OnTimer(UINT nIDEvent);
	afx_msg void OnBtnStatus2();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_VCDEMODLG_H__4ADF9A84_50C7_4723_9948_5329D4B03CCF__INCLUDED_)
