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
	virtual BOOL DestroyWindow();
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
	afx_msg void OnBtnPosMode();
	afx_msg void OnBtnVMode();
	afx_msg void OnBtnVRef();
	afx_msg void OnBtnVAbs();
	afx_msg void OnStopV();
	afx_msg void OnBTNHomeMODE();
	afx_msg void OnBtnHome();
	afx_msg void OnStopHome();
	afx_msg void OnBtnNowP();
	afx_msg void OnBtnIn();
	afx_msg void OnBtnOut();

	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

class CVCDemoDlg2 : public CDialog2
{
	// Construction
public:
	CVCDemoDlg2(CWnd* pParent2 = NULL);	// standard constructor

										// Dialog Data
										//{{AFX_DATA(CVCDemoDlg)
	enum { IDD = IDD_VCDEMO_DIALOG };
	CEdit	m_In2;
	CEdit	m_Out2;
	CEdit	m_P_Now2;
	CEdit	m_Home_V2;
	CEdit	m_V_Abs2;
	CEdit	m_V_Ref2;
	CEdit	m_Ref2;
	CEdit	m_Port2;
	CEdit	m_Maxv2;
	CEdit	m_Dec2;
	CEdit	m_Acc2;
	CEdit	m_Abs2;

	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CVCDemoDlg)
public:
	virtual BOOL DestroyWindow();
protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
														//}}AFX_VIRTUAL

														// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CVCDemoDlg)
	virtual BOOL OnInitDialog2();
	afx_msg void OnSysCommand2(UINT nID, LPARAM lParam);
	afx_msg void OnPaint2();
	afx_msg HCURSOR OnQueryDragIcon2();
	afx_msg void OnButton1();
	afx_msg void OnBtnAcc2();
	afx_msg void OnBtnDec2();
	afx_msg void OnBtnMaxv2();
	afx_msg void OnBtnRef2();
	afx_msg void OnBtnAbs2();
	afx_msg void OnStop2();
	afx_msg void OnHalt2();
	afx_msg void OnBtnPosMode2();
	afx_msg void OnBtnVMode2();
	afx_msg void OnBtnVRef2();
	afx_msg void OnBtnVAbs2();
	afx_msg void OnStopV2();
	afx_msg void OnBTNHomeMODE2();
	afx_msg void OnBtnHome2();
	afx_msg void OnStopHome2();
	afx_msg void OnBtnNowP2();
	afx_msg void OnBtnIn2();
	afx_msg void OnBtnOut2();

	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_VCDEMODLG_H__4ADF9A84_50C7_4723_9948_5329D4B03CCF__INCLUDED_)
