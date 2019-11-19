<%@ Page Language="C#"%>
<%
	string FlowID = Request.QueryString["flowid"];
	string StepID = Request.QueryString["stepid"];
	string GroupID = Request.QueryString["groupid"];
	string TaskID = Request.QueryString["taskid"];
	string InstanceID = Request.QueryString["instanceid"];
	string DisplayModel = Request.QueryString["display"] ?? "0";
	string DBConnID = "06075250-30dc-4d32-bf97-e922cb30fac8";
	string DBTable = "TempTest_CustomForm";
	string DBTablePK = "ID";
	string DBTableTitle = "Title";
if(InstanceID.IsNullOrEmpty()){InstanceID = Request.QueryString["instanceid1"];}	RoadFlow.Platform.Dictionary BDictionary = new RoadFlow.Platform.Dictionary();
	RoadFlow.Platform.WorkFlow BWorkFlow = new RoadFlow.Platform.WorkFlow();
	RoadFlow.Platform.WorkFlowTask BWorkFlowTask = new RoadFlow.Platform.WorkFlowTask();
	string fieldStatus = BWorkFlow.GetFieldStatus(FlowID, StepID);
	LitJson.JsonData initData = BWorkFlow.GetFormData(DBConnID, DBTable, DBTablePK, InstanceID, fieldStatus);
	string TaskTitle = BWorkFlow.GetFromFieldData(initData, DBTable, DBTableTitle);
%>
<link href="Scripts/Forms/flowform.css" rel="stylesheet" type="text/css" />
<script src="Scripts/Forms/common.js" type="text/javascript" ></script>
<input type="hidden" id="Form_ValidateAlertType" name="Form_ValidateAlertType" value="1" />
<input type="hidden" id="Form_TitleField" name="Form_TitleField" value="TempTest_CustomForm.Title" />
<input type="hidden" id="Form_DBConnID" name="Form_DBConnID" value="06075250-30dc-4d32-bf97-e922cb30fac8" />
<input type="hidden" id="Form_DBTable" name="Form_DBTable" value="TempTest_CustomForm" />
<input type="hidden" id="Form_DBTablePk" name="Form_DBTablePk" value="ID" />
<input type="hidden" id="Form_DBTableTitle" name="Form_DBTableTitle" value="Title" />
<input type="hidden" id="Form_AutoSaveData" name="Form_AutoSaveData" value="1" />
<script type="text/javascript">
	var initData = <%=BWorkFlow.GetFormDataJsonString(initData)%>;
	var fieldStatus = "1"=="<%=Request.QueryString["isreadonly"]%>"? {} : <%=fieldStatus%>;
	var displayModel = '<%=DisplayModel%>';
	$(window).load(function (){
		formrun.initData(initData, "TempTest_CustomForm", fieldStatus, displayModel);
	});
</script>
<p style="TEXT-ALIGN: center"> <span style="FONT-SIZE: 20px"><strong>潘永聪请示的报告</strong></span></p><p><span style="FONT-SIZE: 20px"></span> </p><p><span style="FONT-SIZE: 20px"></span> </p><table class="flowformtable" style="WIDTH: 100%" cellspacing="1" cellpadding="0"><tbody><tr class="firstRow"><td style="WORD-BREAK: break-all" valign="top" width="20%">标题：</td><td valign="top" width="80%"><input id="TempTest_CustomForm.Title" title="" class="mytext" style="WIDTH: 70%" maxlength="200" value="<%=RoadFlow.Platform.Users.CurrentUserName%>的报告请示" name="TempTest_CustomForm.Title" valuetype="0" type1="flow_text" isflow="1"/></td></tr><tr><td style="WORD-BREAK: break-all" valign="top" width="20%">内容</td><td valign="top" width="80%"><textarea id="TempTest_CustomForm.Contents" class="mytext" style="HEIGHT: 100px; WIDTH: 70%" name="TempTest_CustomForm.Contents" maxlength="1000" type1="flow_textarea" isflow="1"></textarea></td></tr></tbody></table><p> </p>