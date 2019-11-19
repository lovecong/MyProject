<%@ Page Language="C#"%>
<%
	string FlowID = Request.QueryString["flowid"];
	string StepID = Request.QueryString["stepid"];
	string GroupID = Request.QueryString["groupid"];
	string TaskID = Request.QueryString["taskid"];
	string InstanceID = Request.QueryString["instanceid"];
	string DisplayModel = Request.QueryString["display"] ?? "0";
	string DBConnID = "06075250-30dc-4d32-bf97-e922cb30fac8";
	string DBTable = "test_Task";
	string DBTablePK = "id";
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
<input type="hidden" id="test_Task.Title" name="test_Task.Title" value="<%=TaskTitle.IsNullOrEmpty() ? BWorkFlow.GetAutoTaskTitle(FlowID, StepID, Request.QueryString["groupid"]) : TaskTitle %>" />
<input type="hidden" id="Form_TitleField" name="Form_TitleField" value="test_Task.Title" />
<input type="hidden" id="Form_DBConnID" name="Form_DBConnID" value="06075250-30dc-4d32-bf97-e922cb30fac8" />
<input type="hidden" id="Form_DBTable" name="Form_DBTable" value="test_Task" />
<input type="hidden" id="Form_DBTablePk" name="Form_DBTablePk" value="id" />
<input type="hidden" id="Form_DBTableTitle" name="Form_DBTableTitle" value="Title" />
<input type="hidden" id="Form_AutoSaveData" name="Form_AutoSaveData" value="1" />
<script type="text/javascript">
	var initData = <%=BWorkFlow.GetFormDataJsonString(initData)%>;
	var fieldStatus = "1"=="<%=Request.QueryString["isreadonly"]%>"? {} : <%=fieldStatus%>;
	var displayModel = '<%=DisplayModel%>';
    alert(fieldStatus);
	$(window).load(function (){
		formrun.initData(initData, "test_Task", fieldStatus, displayModel);
	});
</script>
<p style="TEXT-ALIGN: center"><span style="FONT-SIZE: 34px"><strong>院阅文系统</strong></span></p><p><span style="FONT-SIZE: 26px"></span></p><table class="flowformtable" cellpadding="0" cellspacing="1" style="width:85% "><tbody><tr class="firstRow"><td width="10%" valign="top" style="word-break: break-all;">标题</td><td width="100%" valign="top" style="word-break: break-all;"><input type="text" id="test_Task.Title" type1="flow_text" name="test_Task.Title" value="<%=BWorkFlow.GetStepName(StepID.ToGuid(), FlowID.ToGuid(), true)%>" style="width:100%" valuetype="0" isflow="1" class="mytext" title=""/></td></tr><tr><td width="10" valign="top" style="word-break: break-all;">内容</td><td width="80" valign="top" style="word-break: break-all;"><textarea isflow="1" type1="flow_textarea" id="test_Task.Context" name="test_Task.Context" class="mytext" style="width:100%;height:200px" maxlength="5000"></textarea></td></tr><tr><td width="10" valign="top" style="word-break: break-all;">附件<br/></td><td width="80" valign="top"><input type="text" type1="flow_files" id="test_Task.FJ" name="test_Task.FJ" value="" style="width:30%" filetype="" isflow="1" class="myfile" title=""/></td></tr></tbody></table><p><br/></p><p><br/></p>