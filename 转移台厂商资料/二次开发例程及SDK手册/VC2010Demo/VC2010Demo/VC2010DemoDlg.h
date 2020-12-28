
// VC2010DemoDlg.h : 头文件
//

#pragma once
#include "afxwin.h"


// CVC2010DemoDlg 对话框
class CVC2010DemoDlg : public CDialogEx
{
// 构造
public:
	CVC2010DemoDlg(CWnd* pParent = NULL);	// 标准构造函数

// 对话框数据
	enum { IDD = IDD_VC2010DEMO_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支持


// 实现
protected:
	HICON m_hIcon;

	// 生成的消息映射函数
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
