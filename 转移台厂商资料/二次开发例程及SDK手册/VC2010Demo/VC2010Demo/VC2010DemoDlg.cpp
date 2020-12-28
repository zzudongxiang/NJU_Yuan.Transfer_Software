
// VC2010DemoDlg.cpp : 实现文件
//

#include "stdafx.h"
#include "VC2010Demo.h"
#include "VC2010DemoDlg.h"
#include "afxdialogex.h"
#include "MT_API.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// 用于应用程序“关于”菜单项的 CAboutDlg 对话框

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// 对话框数据
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

// 实现
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CVC2010DemoDlg 对话框




CVC2010DemoDlg::CVC2010DemoDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CVC2010DemoDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CVC2010DemoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT1, m_Port);
}

BEGIN_MESSAGE_MAP(CVC2010DemoDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, &CVC2010DemoDlg::OnBnClickedButton1)
END_MESSAGE_MAP()


// CVC2010DemoDlg 消息处理程序

BOOL CVC2010DemoDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 将“关于...”菜单项添加到系统菜单中。

	// IDM_ABOUTBOX 必须在系统命令范围内。
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// 设置此对话框的图标。当应用程序主窗口不是对话框时，框架将自动
	//  执行此操作
	SetIcon(m_hIcon, TRUE);			// 设置大图标
	SetIcon(m_hIcon, FALSE);		// 设置小图标

	// TODO: 在此添加额外的初始化代码

	MT_Init();
	m_Port.SetWindowText(_T("COM1"));

	return TRUE;  // 除非将焦点设置到控件，否则返回 TRUE
}

void CVC2010DemoDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// 如果向对话框添加最小化按钮，则需要下面的代码
//  来绘制该图标。对于使用文档/视图模型的 MFC 应用程序，
//  这将由框架自动完成。

void CVC2010DemoDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 用于绘制的设备上下文

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 使图标在工作区矩形中居中
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 绘制图标
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

//当用户拖动最小化窗口时系统调用此函数取得光标
//显示。
HCURSOR CVC2010DemoDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


int CStrToChar(char* pDest, CString&  pSource)  
{  
    size_t i;  
    wchar_t* pawstr = NULL;  
    pawstr =   pSource.GetBuffer(pSource.GetLength()+1);  // 先转换为宽字节  
    //wcstombs(pDest, pawstr, pSource.GetLength()+1);     // 非安全版  
    wcstombs_s(&i, pDest, pSource.GetLength()+1, pSource, pSource.GetLength()+1);  // 安全版  
    return 0;  
}  
void CVC2010DemoDlg::OnBnClickedButton1()
{
	// TODO: 在此添加控件通知处理程序代码
		// TODO: 在此添加控件通知处理程序代码
	CString sCOM;
	INT32 iResult;
	MT_Close_USB();
	MT_Close_UART();
    m_Port.GetWindowText(sCOM);
	//打开串口
	
	char ch[10];  
    char* p = ch; 
//vc 2010默认是unicode，CString也是unicode的,采用VC6的转换方式下，
//可以修改工程属性为非unicode
	 
//转换为char 方法1
   // wchar_t* pawstr = NULL;  
   // pawstr =   sCOM.GetBuffer(sCOM.GetLength()+1);  // 先转换为宽字节   
   //wcstombs(pDest, pawstr, pSource.GetLength()+1)
size_t i; 
//转换为char 方法2
    wcstombs_s(&i, p, sCOM.GetLength()+1, sCOM, sCOM.GetLength()+1);  // 安全版 

	//char* p="COM4";//确定端口直接用这个 
	iResult=MT_Open_UART(p);//需要ansi字符
	if(iResult!=R_OK)
	{
		MessageBox(_T("Port Error"));
		return;
	}
	//检测板卡
	iResult=MT_Check();
	if(R_OK!=iResult)
	{
		MessageBox(_T("NO Card"));
		return;
	}
	//连接成功
	MessageBox(_T("OK"));
}


BOOL CVC2010DemoDlg::DestroyWindow()
{
	// TODO: 在此添加专用代码和/或调用基类
	MT_DeInit();
	return CDialogEx::DestroyWindow();
}
