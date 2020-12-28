// VCDemoDlg.cpp : implementation file
//

#include "stdafx.h"
#include "VCDemo.h"
#include "VCDemoDlg.h"
#include "MT_API.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CVCDemoDlg dialog

CVCDemoDlg::CVCDemoDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CVCDemoDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CVCDemoDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CVCDemoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CVCDemoDlg)
	DDX_Control(pDX, IDC_CHK_NEG, m_Neg);
	DDX_Control(pDX, IDC_CHK_POS, m_Pos);
	DDX_Control(pDX, IDC_CHK_ZERO, m_Zero);
	DDX_Control(pDX, IDC_CHK_RUN, m_Run);
	DDX_Control(pDX, IDC_CHK_DIR, m_Dir);
	DDX_Control(pDX, IDC_NOW_V, m_V_Now);
	DDX_Control(pDX, IDC_TIMER, m_Timer);
	DDX_Control(pDX, IDC_AXIS, m_Axis);
	DDX_Control(pDX, IDC_IN, m_In);
	DDX_Control(pDX, IDC_OUT, m_Out);
	DDX_Control(pDX, IDC_NOW_P, m_P_Now);
	DDX_Control(pDX, IDC_HOME_V, m_Home_V);
	DDX_Control(pDX, IDC_V_ABS, m_V_Abs);
	DDX_Control(pDX, IDC_V_REF, m_V_Ref);
	DDX_Control(pDX, IDC_REF, m_Ref);
	DDX_Control(pDX, IDC_PORT, m_Port);
	DDX_Control(pDX, IDC_MAXV, m_Maxv);
	DDX_Control(pDX, IDC_DEC, m_Dec);
	DDX_Control(pDX, IDC_ACC, m_Acc);
	DDX_Control(pDX, IDC_ABS, m_Abs);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CVCDemoDlg, CDialog)
	//{{AFX_MSG_MAP(CVCDemoDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BTN_CHECK, OnButton1)
	ON_BN_CLICKED(IDC_BTN_ACC, OnBtnAcc)
	ON_BN_CLICKED(IDC_BTN_DEC, OnBtnDec)
	ON_BN_CLICKED(IDC_BTN_MAXV, OnBtnMaxv)
	ON_BN_CLICKED(IDC_BTN_REF, OnBtnRef)
	ON_BN_CLICKED(IDC_BTN_ABS, OnBtnAbs)
	ON_BN_CLICKED(IDC_STOP, OnStop)
	ON_BN_CLICKED(IDC_HALT, OnHalt)
	ON_BN_CLICKED(IDC_BTN_V_REF, OnBtnVRef)
	ON_BN_CLICKED(IDC_BTN_V_ABS, OnBtnVAbs)
	ON_BN_CLICKED(IDC_STOP_V, OnStopV)
	ON_BN_CLICKED(IDC_BTN_HOME, OnBtnHome)
	ON_BN_CLICKED(IDC_STOP_HOME, OnStopHome)
	ON_BN_CLICKED(IDC_BTN_IN, OnBtnIn)
	ON_BN_CLICKED(IDC_BTN_OUT, OnBtnOut)
	ON_BN_CLICKED(IDC_BTN_CHECK2, OnBtnCheck2)
	ON_WM_CLOSE()
	ON_BN_CLICKED(IDC_BTN_STATUS, OnBtnStatus)
	ON_WM_TIMER()
	ON_BN_CLICKED(IDC_BTN_STATUS2, OnBtnStatus2)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CVCDemoDlg message handlers

BOOL CVCDemoDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	//初始化运行环境
    MT_Init();
    m_Port.SetWindowText(_T("COM1"));
	m_Acc.SetWindowText(_T("500"));
	m_Dec.SetWindowText(_T("500"));
	m_Maxv.SetWindowText(_T("5000"));
	m_Ref.SetWindowText(_T("10000"));
    m_Abs.SetWindowText(_T("10000"));
		
	m_V_Abs.SetWindowText(_T("3200"));
	m_V_Ref.SetWindowText(_T("3200"));
	m_Home_V.SetWindowText(_T("-3200"));

	m_Out.SetWindowText(_T("255"));

	m_Axis.SetWindowText(_T("0"));
	m_Timer.SetWindowText(_T("1000"));
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CVCDemoDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CVCDemoDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CVCDemoDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}



void CVCDemoDlg::OnButton1() 
{
	// TODO: Add your control notification handler code here
	CString sCOM;
	INT32 iResult;
	MT_Close_USB();
	MT_Close_UART();
	//打开串口
    m_Port.GetWindowText(sCOM);

    char *p = (LPSTR)(LPCTSTR)sCOM;

	iResult=MT_Open_UART(p);
	if(iResult!=R_OK)
	{
		MessageBox("Port Error");
		return;
	}
	//检测板卡
	iResult=MT_Check();
	if(R_OK!=iResult)
	{
		MessageBox("NO Card");
		return;
	}
	//检测板卡成功
	MessageBox("OK");
}

void CVCDemoDlg::OnBtnAcc() 
{
	// TODO: Add your control notification handler code here
	//设置加速度
	CString sValue;
	m_Acc.GetWindowText(sValue);
	int iAcc;
	iAcc=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	iResult=MT_Set_Axis_Acc(iID,iAcc);
	if(R_OK==iResult)
	{
         MessageBox("OK");
	}

}

void CVCDemoDlg::OnBtnDec() 
{
	// TODO: Add your control notification handler code here
	//设置减速度
	CString sValue;
	m_Dec.GetWindowText(sValue);
	int iDec;
	iDec=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	iResult=MT_Set_Axis_Dec(iID,iDec);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnMaxv() 
{
	// TODO: Add your control notification handler code here
	//设置位置模式最大速度
	CString sValue;
	m_Maxv.GetWindowText(sValue);
	int iMaxv;
	iMaxv=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	iResult=MT_Set_Axis_Position_V_Max(iID,iMaxv);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnRef() 
{
	// TODO: Add your control notification handler code here
	//设置相对方式移动，支持正负值
	CString sValue;

	m_Ref.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	//进入位置模式，如果过程中模式不改，只需要设置一次，也可以放在窗口初始化
	MT_Set_Axis_Mode_Position(iID);
	iResult=MT_Set_Axis_Position_P_Target_Rel(iID,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnAbs() 
{
	// TODO: Add your control notification handler code here
	//设置绝对方式移动，支持正负值
	CString sValue;

	m_Ref.GetWindowText(sValue);
	int iAbs;
	iAbs=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	//进入位置模式，如果过程中模式不改，只需要设置一次，也可以放在窗口初始化
	MT_Set_Axis_Mode_Position(iID);
	iResult=MT_Set_Axis_Position_P_Target_Abs(iID,iAbs);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}		
}

void CVCDemoDlg::OnStop() 
{
	// TODO: Add your control notification handler code here
	//以指定的减速度停止
    INT32 iResult;
	CString sValue;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	iResult=MT_Set_Axis_Position_Stop(iID);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnHalt() 
{
	// TODO: Add your control notification handler code here
	//立即停止
    INT32 iResult;
	int iID;
	CString sValue;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	iResult=MT_Set_Axis_Halt(iID);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}		
}


void CVCDemoDlg::OnBtnVRef() 
{
	//设置相对方式调速，支持正负值
	CString sValue;
	
	m_V_Ref.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	//进入速度模式，如果过程中不变模式，只需要设置一次,可以放在窗口初始化中
	MT_Set_Axis_Mode_Velocity(iID);

	iResult=MT_Set_Axis_Velocity_V_Target_Rel(iID,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnVAbs() 
{
	// TODO: Add your control notification handler code here
	//设置绝对方式调速，支持正负值
	CString sValue;
	
	m_V_Abs.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	//进入速度模式，如果过程中不变模式，只需要设置一次,可以放在窗口初始化中
	MT_Set_Axis_Mode_Velocity(iID);
	iResult=MT_Set_Axis_Velocity_V_Target_Abs(iID,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}		
}

void CVCDemoDlg::OnStopV() 
{
	//以指定的减速度停止
    INT32 iResult;
	int iID;
	CString sValue;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	iResult=MT_Set_Axis_Velocity_Stop(iID);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}


void CVCDemoDlg::OnBtnHome() 
{
	//设置指定速度找零位，支持正负值，慢速会精确一些
	CString sValue;
	
	m_Home_V.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	MT_Set_Axis_Mode_Home(iID);
	iResult=MT_Set_Axis_Home_V(iID,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnStopHome() 
{
	// TODO: Add your control notification handler code here
	//以指定的减速度停止
    INT32 iResult;
	int iID;
	CString sValue;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	iResult=MT_Set_Axis_Home_Stop(iID);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}


void CVCDemoDlg::OnBtnIn() 
{
	// TODO: Add your control notification handler code here
	//读取当期位置
	CString sValue;
	int iValue;
    INT32 iResult;
    iResult=MT_Get_Optic_In_All(&iValue);
	if(R_OK==iResult)
	{
		MessageBox("OK");
		sValue.Format("%d",iValue);
		m_In.SetWindowText(sValue);	
	}	// TODO: Add your control notification handler code here
	
}

void CVCDemoDlg::OnBtnOut() 
{
	//设置指定速度找零位，支持正负值，慢速会精确一些
	CString sValue;
	
	m_Out.GetWindowText(sValue);
	int iValue;
	iValue=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Optic_Out_All(iValue);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnCheck2() 
{
	// TODO: Add your control notification handler code here
	// TODO: Add your control notification handler code here
	CString sCOM;
	INT32 iResult;
	MT_Close_USB();
	MT_Close_UART();

	//打开USB
	iResult=MT_Open_USB();
	if(iResult!=R_OK)
	{
		MessageBox("Port Error");
		return;
	}
	//检测板卡
	iResult=MT_Check();
	if(R_OK!=iResult)
	{
		MessageBox("NO Card");
		return;
	}
	//检测板卡成功
	MessageBox("OK");	
}

void CVCDemoDlg::OnClose() 
{
	// TODO: Add your message handler code here and/or call default
	MT_DeInit();
	CDialog::OnClose();
}

void CVCDemoDlg::OnBtnStatus() 
{
	// TODO: Add your control notification handler code here
	CString sValue;
	m_Timer.GetWindowText(sValue);
	int iInterval;
	iInterval=atoi(sValue);
	//启动定时器，在定时器中连续进行状态读取
	SetTimer(1,iInterval,NULL);
}

void CVCDemoDlg::OnTimer(UINT nIDEvent) 
{
	// TODO: Add your message handler code here and/or call default
	//定制器中读取状态，可以通过在本定时器中通过判断状态来完成连续组合动作
    CString sValue;
	int iID;
	m_Axis.GetWindowText(sValue);
	iID=atoi(sValue);
	//读取当前位置
	int iP_Now;
	MT_Get_Axis_Software_P_Now(iID,&iP_Now);
	sValue.Format("%d",iP_Now);
    m_P_Now.SetWindowText(sValue);

	//读取当前速度
	int iV_Now;
	MT_Get_Axis_V_Now(iID,&iV_Now);
	sValue.Format("%d",iV_Now);
    m_V_Now.SetWindowText(sValue);

	//读取当前运动状态
	byte iRun,iDir,iNeg,iPos,iZero,iMode;

    MT_Get_Axis_Status(iID,&iRun,&iDir,&iNeg,&iPos,&iZero,&iMode);
    
	m_Run.SetCheck(iRun>0);
	m_Dir.SetCheck(iDir>0);
	m_Neg.SetCheck(iNeg>0);
	m_Pos.SetCheck(iPos>0);
	m_Zero.SetCheck(iZero>0);


	CDialog::OnTimer(nIDEvent);
}

void CVCDemoDlg::OnBtnStatus2() 
{
	// TODO: Add your control notification handler code here
	//关闭定时器
	KillTimer(1);
}
