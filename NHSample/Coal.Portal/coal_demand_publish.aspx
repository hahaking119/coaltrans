<%@ Page Language="C#" AutoEventWireup="true" CodeFile="coal_demand_publish.aspx.cs" Inherits="coal_demand_publish" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>����ú̿��Ӧ��Ϣ</title>
<link href="css/admin_style.css" type="text/css" rel="stylesheet" rev="stylesheet" media="all" />
<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/uc.js"></script>
</head>
<body>
   <form id="form1" runat="server">
   <div id="h_wrapper">
    <!--#include File="uc_top.inc"-->
	<div id="h_content" class="clearfix">
		<div id="nav" class="h_sideBar">
			<div id="nav_tree" class="h_tree"></div>
		</div>
		<div class="h_main">
			<dl class="h_tips">
				<dt>Ϊ��������ܸ���ȷ�ҵ����Ĳ�Ʒ�������������¼������������Ϣ���ȣ���ø��õ�������</dt>
				<dd>1��һ����Ϣֻ����һ����Ʒ��</dd>
				<dd>2�����Ĳ�Ʒ������س����ڱ����У�</dd>
				<dd>3������������д��Ӧ��Ϣ</dd>
			</dl>
			<div class="h_columns clearfix">
				<div class="h_column h_colW2">
					<div class="h_mainTitle">
						<ul class="h_itemsMenu" id="tabMenu">
							<li class="active"><a href="javascript:void(0);">ú̿��Ӧ</a></li>
						</ul>
					</div>
					<div id="tabMenu_Content0">
							<div class="h_itemsBody h_item_bb">
								<table>
								    <tr>
										<th width="15%"><span>*</span>��  �⣺</th>
										<td width="30%">
										    <input name="text" type="text" class="h_text" style="width:300px" />
										    <div class="h_alert">����д���⣡</div><!-- ��ʾ˵������ -->
										</td>
									</tr>
									<tr>
										<th width="15%"><span>*</span>�����ȣ�</th>
										<td width="30%">
										<select>
										    <option value="0">С����</option>
										    <option value="1">������</option>
										</select>
										<div class="h_alert">��ѡ���Ʒ��</div><!-- ��ʾ˵������ -->
										</td>
										<th width="15%"><span>*</span>��̿���ͣ�</th>
										<td>
											<select>
												<option value="0">��ѡ��</option>
											</select>
										</td>
									</tr>
									<tr>
										<th><span>*</span>�����أ�</th>
										<td>
											<select>
												<option value="0">ʡ��</option>
											</select>
											<select>
												<option value="0">����</option>
											</select>
											<span class="h_over"></span><!-- ѡ���״̬ -->
										</td>
										<th><span>*</span>��������</th>
										<td>
											<input name="text" type="text" class="h_text" /> ��
										</td>
									</tr>
									<tr>
										<th><span>*</span>�ۡ���</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> Ԫ/��
										</td>
										<th><span>*</span>����أ�</th>
										<td>
											<select>
												<option value="0">ʡ��</option>
											</select>
											<select>
												<option value="0">����</option>
											</select>
										</td>
									</tr>
									<tr>
										<th>�ӷ��ݣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
										<th>�򡡷ݣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
											<span class="h_over"></span><!-- ѡ���״̬ -->
										</td>
									</tr>
									<tr>
										<th>��еǿ�ȣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
										<th>����ǿ�ȣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
									</tr>
									<tr>
										<th>�ҡ��ݣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
										<th>ˮ���ݣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
									</tr>
									<tr>
										<th>��ĥǿ�ȣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
										<th>�����ʣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
									</tr>
									<tr>
										<th>��Ӧ�ԣ�</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" />
										</td>
										<th>��ĭ������</th>
										<td>
											<input name="text" type="text" value="0" class="h_text" /> %
										</td>
									</tr>
									<tr>
										<th><span>*</span>��Ϣ��Ч�ڣ�</th>
										<td>
											<select>
												<option value="0">��ѡ��</option>
											</select>
										</td>
										<th><span>*</span>������ʽ��</th>
										<td>
											<select>
												<option value="0">��ѡ��</option>
											</select>
										</td>
									</tr>
								</table>
							</div>
							<div class="h_itemsBody">
								<table>
									<tr>
										<th width="15%"><span>*</span>��ϵ�ˣ�</th>
										<td width="30%">
											<input name="text" type="text" class="h_text" />
											<div class="h_alert">��������ϵ��������</div><!-- ��ʾ˵������ -->
										</td>
										<th width="15%"> </th>
										<td> </td>
									</tr>
									<tr>
										<th><span>*</span>ְ����</th>
										<td>
											<select>
												<option value="0">��ѡ��</option>
											</select>
										</td>
										<th> </th>
										<td> </td>
									</tr>
									<tr>
										<th><span>*</span>��ϵ�绰��</th>
										<td>
											<input name="text" type="text" class="h_text" /> -
											<input name="text" type="text" class="h_text2" />
										</td>
										<th><span>*</span>�����棺</th>
										<td>
											<input name="text" type="text" class="h_text" /> -
											<input name="text" type="text" class="h_text2" />
										</td>
									</tr>
									<tr>
										<th><span>*</span>�֡�����</th>
										<td>
											<input name="text" type="text" class="h_text3" />
										</td>
										<th><span>*</span>�����ʼ���</th>
										<td>
											<input name="text" type="text" class="h_text3" />
										</td>
									</tr>
									<tr>
										<th>��˾��ַ��</th>
										<td>
											<input name="text" type="text" class="h_text4" />
										</td>
										<th> </th>
										<td>
										</td>
									</tr>
									<tr>
										<th> </th>
										<td>
                                            <input name="submit" type="button" value="�� ��" class="h_buttun1" />
											<input name="reset" type="button" value="�� ��" class="h_buttun1" />
										</td>
										<th> </th>
										<td> </td>
									</tr>
								</table>
							</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<input id="current_menu" type="hidden" value="menu_5" />
<input id="parent_menu" type="hidden" value="menu_4" />
<p id="h_footer">Copyright &copy; 2009 ����ú̿��ҵ�� ���죺�й�ú̿��ҵЭ�� ����֧�֣�������ú��ͨ�Ƽ����޹�˾</p>
    </form>
</body>
</html>