
// VC2010DemoDlg.h : ͷ�ļ�
//

#pragma once
#include "afxwin.h"


// CVC2010DemoDlg �Ի���
class CVC2010DemoDlg : public CDialogEx
{
// ����
public:
	CVC2010DemoDlg(CWnd* pParent = NULL);	// ��׼���캯��

// �Ի�������
	enum { IDD = IDD_VC2010DEMO_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV ֧��


// ʵ��
protected:
	HICON m_hIcon;

	// ���ɵ���Ϣӳ�亯��
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButton1();
	CEdit m_Port;
	virtual BOOL DestroyWindow();
};
