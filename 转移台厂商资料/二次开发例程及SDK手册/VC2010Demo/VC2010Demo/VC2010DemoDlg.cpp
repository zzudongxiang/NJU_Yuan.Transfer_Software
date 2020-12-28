
// VC2010DemoDlg.cpp : ʵ���ļ�
//

#include "stdafx.h"
#include "VC2010Demo.h"
#include "VC2010DemoDlg.h"
#include "afxdialogex.h"
#include "MT_API.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// ����Ӧ�ó��򡰹��ڡ��˵���� CAboutDlg �Ի���

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// �Ի�������
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV ֧��

// ʵ��
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


// CVC2010DemoDlg �Ի���




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


// CVC2010DemoDlg ��Ϣ�������

BOOL CVC2010DemoDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// ��������...���˵�����ӵ�ϵͳ�˵��С�

	// IDM_ABOUTBOX ������ϵͳ���Χ�ڡ�
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

	// ���ô˶Ի����ͼ�ꡣ��Ӧ�ó��������ڲ��ǶԻ���ʱ����ܽ��Զ�
	//  ִ�д˲���
	SetIcon(m_hIcon, TRUE);			// ���ô�ͼ��
	SetIcon(m_hIcon, FALSE);		// ����Сͼ��

	// TODO: �ڴ���Ӷ���ĳ�ʼ������

	MT_Init();
	m_Port.SetWindowText(_T("COM1"));

	return TRUE;  // ���ǽ��������õ��ؼ������򷵻� TRUE
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

// �����Ի��������С����ť������Ҫ����Ĵ���
//  �����Ƹ�ͼ�ꡣ����ʹ���ĵ�/��ͼģ�͵� MFC Ӧ�ó���
//  �⽫�ɿ���Զ���ɡ�

void CVC2010DemoDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // ���ڻ��Ƶ��豸������

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// ʹͼ���ڹ����������о���
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// ����ͼ��
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

//���û��϶���С������ʱϵͳ���ô˺���ȡ�ù��
//��ʾ��
HCURSOR CVC2010DemoDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


int CStrToChar(char* pDest, CString&  pSource)  
{  
    size_t i;  
    wchar_t* pawstr = NULL;  
    pawstr =   pSource.GetBuffer(pSource.GetLength()+1);  // ��ת��Ϊ���ֽ�  
    //wcstombs(pDest, pawstr, pSource.GetLength()+1);     // �ǰ�ȫ��  
    wcstombs_s(&i, pDest, pSource.GetLength()+1, pSource, pSource.GetLength()+1);  // ��ȫ��  
    return 0;  
}  
void CVC2010DemoDlg::OnBnClickedButton1()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������
		// TODO: �ڴ���ӿؼ�֪ͨ����������
	CString sCOM;
	INT32 iResult;
	MT_Close_USB();
	MT_Close_UART();
    m_Port.GetWindowText(sCOM);
	//�򿪴���
	
	char ch[10];  
    char* p = ch; 
//vc 2010Ĭ����unicode��CStringҲ��unicode��,����VC6��ת����ʽ�£�
//�����޸Ĺ�������Ϊ��unicode
	 
//ת��Ϊchar ����1
   // wchar_t* pawstr = NULL;  
   // pawstr =   sCOM.GetBuffer(sCOM.GetLength()+1);  // ��ת��Ϊ���ֽ�   
   //wcstombs(pDest, pawstr, pSource.GetLength()+1)
size_t i; 
//ת��Ϊchar ����2
    wcstombs_s(&i, p, sCOM.GetLength()+1, sCOM, sCOM.GetLength()+1);  // ��ȫ�� 

	//char* p="COM4";//ȷ���˿�ֱ������� 
	iResult=MT_Open_UART(p);//��Ҫansi�ַ�
	if(iResult!=R_OK)
	{
		MessageBox(_T("Port Error"));
		return;
	}
	//���忨
	iResult=MT_Check();
	if(R_OK!=iResult)
	{
		MessageBox(_T("NO Card"));
		return;
	}
	//���ӳɹ�
	MessageBox(_T("OK"));
}


BOOL CVC2010DemoDlg::DestroyWindow()
{
	// TODO: �ڴ����ר�ô����/����û���
	MT_DeInit();
	return CDialogEx::DestroyWindow();
}
