<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentMasterEntry.aspx.cs"
    Inherits="StudentMasterEntry" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Student Master Entry</title>
<script type="text/javascript" src="Assets/js/jquery-1.11.3.min.js"></script>
<link href="Assets/css/bootstrap.css" rel="stylesheet" type="text/css" />
<script src="Assets/js/bootstrap.js" type="text/javascript"></script>
<script src="Assets/js/bootstrap.min.js" type="text/javascript"></script>
<script type="text/javascript" src="Assets/js/bootstrap-datepicker.min.js"></script>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
<link href="Assets/css/bootstrap-select.css" rel="stylesheet" type="text/css" />
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
<script src="Assets/js/bootstrap-select.js" type="text/javascript"></script>
    <script type="text/javascript">
        function validate() {
            var inVal = $("#txtRegNo").val();
            if (inVal.length == 0) {
                alert("Please Enter Reg No");
                $("#txtRegNo").focus();
                return false;
            }
            inVal = $("#txtIDNo").val();
            if (inVal.length == 0) {
                alert("Please Enter ID No");
                $("#txtIDNo").focus();
                return false; 
            }
            inVal = $("#txtUID").val();
            if (inVal.length == 0) {
                alert("Please Enter Aadhaar");
                $("#txtUID").focus();
                return false;
            }
            if (inVal.length > 12 || inVal.length < 12) {
                alert("Invalid Aadhaar Length");
                $("#txtUID").focus();
                return false;
            }
            inVal = $("#txtFName").val();
            if (inVal.length == 0) {
                alert("Please Enter First Name");
                $("#txtFName").focus();
                return false;
            }
            inVal = $("#txtMName").val();
            if (inVal.length == 0) {
                alert("Please Enter Middle Name");
                $("#txtMName").focus();
                return false;
            }
            inVal = $("#txtSName").val();
            if (inVal.length == 0) {
                alert("Please Enter Last Name");
                $("#txtSName").focus();
                return false;
            }
            inVal = $("#txtMotherName").val();
            if (inVal.length == 0) {
                alert("Please Enter Mother's Name");
                $("#txtMotherName").focus();
                return false;
            }
            inVal = $("#txtReligion").val();
            if (inVal.length == 0) {
                alert("Please Enter Religion");
                $("#txtReligion").focus();
                return false;
            }
            inVal = $("#txtCaste").val();
            if (inVal.length == 0) {
                alert("Please Enter Caste");
                $("#txtCaste").focus();
                return false;
            }
            inVal = $("#txtSubcast").val();
            if (inVal.length == 0) {
                alert("Please Enter Sub Caste");
                $("#txtSubcast").focus();
                return false;
            }
            inVal = $("#txtMothertongue").val();
            if (inVal.length == 0) {
                alert("Please Enter Mothertongue");
                $("#txtMothertongue").focus();
                return false;
            }
            inVal = $("#txtVillage").val();
            if (inVal.length == 0) {
                alert("Please Enter Village");
                $("#txtVillage").focus();
                return false;
            }
            inVal = $("#txtTaluka").val();
            if (inVal.length == 0) {
                alert("Please Enter Taluka");
                $("#txtTaluka").focus();
                return false;
            }
            inVal = $("#txtDist").val();
            if (inVal.length == 0) {
                alert("Please Enter District");
                $("#txtDist").focus();
                return false;
            }
            inVal = $("#txtState").val();
            if (inVal.length == 0) {
                alert("Please Enter State");
                $("#txtState").focus();
                return false;
            }
            inVal = $("#txtCountry").val();
            if (inVal.length == 0) {
                alert("Please Enter Country");
                $("#txtCountry").focus();
                return false;
            }
            inVal = $("#txtPrevSchoolName").val();
            if (inVal.length == 0) {
                alert("Please Enter Prev School Name");
                $("#txtPrevSchoolName").focus();
                return false;
            }
        }
     </script>
     
<script type="text/javascript">
    jQuery(document).ready(function () {
        $("#txtUID").on('change', function () {
            var Param1 = $("#txtRegNo").val();
            var Param2 = $("#txtUID").val();
            debugger;
            $.ajax({
                type: "POST",
                url: "StudentMasterEntry.aspx/ValidateAadharNo",
                data: "{ Param1: '" + Param1 + "',Param2: '" + Param2 + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "text",
                success: function (data) {
                    $.each(jQuery.parseJSON(data), function () {
                        if (this != '') {
                            alert(this);
                        }
                    });
                },
                Error: function (x, e) {
                    alert('error encountered');

                }
            });
        });

        $("#txtRegNo").on('change', function () {
            debugger;
            var Param1 = $("#txtRegNo").val();
            var Param2 = $("#txtGroup").val();
            debugger;
            $.ajax({
                type: "POST",
                url: "StudentMasterEntry.aspx/ValidateRegNo",
                data: "{ Param1: '" + Param1 + "',Param2: '" + Param2 + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "text",
                success: function (data) {
                    $.each(jQuery.parseJSON(data), function () {
                        if (this != '') {
                            alert(this);
                        }
                    });
                },
                Error: function (x, e) {
                    alert('error encountered');

                }
            });
        });
    });
</script>

</head>
<body>
    <script src="Assets/js/bootstrap.js" type="text/javascript"></script>
    <div class="container">
        <form id="form1" runat="server">
        <h1>
            General Register No. 1 - Student Data</h1>
        <br />
        <div class="form-group row">
            <asp:Label Text="Status" ID="lblStatus" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="txtStatus" runat="server">
                <asp:ListItem Text="Active" Selected="True" Value="Active">
                </asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group row">
             
            <asp:Label Text="Group" ID="lblGroup" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="txtGroup" runat="server">
                <asp:ListItem Text="Pre-Primary" Selected="True" Value="PP"></asp:ListItem>
                <asp:ListItem Text="Primary" Selected="False" Value="PR"></asp:ListItem>
                <asp:ListItem Text="Secondary" Selected="False" Value="SS"></asp:ListItem>
                <asp:ListItem Text="High Secondary" Selected="False" Value="HS">
                </asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label Text="Register No" ID="lblRegistration" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtRegNo" class="form-control" placeholder="Enter Register No" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group row">
            <asp:Label Text="ID No" ID="lblIDNo" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtIDNo" class="form-control" placeholder="Enter ID No" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label Text="UID No" ID="lblUID" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtUID" class="form-control" placeholder="Enter UID No" runat="server" ClientIDMode="Static"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label Text="Name of Pupil" ID="lblStudentName" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-2">
                <asp:TextBox ID="txtFName" class="form-control" placeholder="First Name" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:TextBox ID="txtMName" class="form-control" placeholder="Middle Name" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2 ">
                <asp:TextBox ID="txtSName" class="form-control" placeholder="Surname" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label Text="Mother's Name" ID="lblMotherName" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtMotherName" class="form-control" placeholder="Enter Mother's Name"
                    runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label Text="Religion/Caste/SubCaste" ID="lblCast" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-2">
                <asp:TextBox ID="txtReligion" class="form-control" placeholder="Religion" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2 ">
                <asp:TextBox ID="txtCaste" class="form-control" placeholder="Caste" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2 ">
                <asp:TextBox ID="txtSubcast" class="form-control" placeholder="Subcaste" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Nationality & Mothertongue" ID="lblNationality" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-2">
                <asp:DropDownList ID="txtNationality" runat="server">
                <asp:ListItem Text="Indian" Value="Indian" Selected="True"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-sm-2 ">
                <asp:TextBox ID="txtMothertongue" class="form-control" placeholder="Mothertongue"
                    runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Birth Place" ID="Label1" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-2">
                <asp:TextBox ID="txtVillage" class="form-control" placeholder="Village" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:TextBox ID="txtTaluka" class="form-control" placeholder="Taluka" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:TextBox ID="txtDist" class="form-control" placeholder="District" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:TextBox ID="txtState" class="form-control" placeholder="State" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:TextBox ID="txtCountry" class="form-control" placeholder="Country" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group row">
            <asp:Label Text="Date of Birth" ID="lblDOB" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <div class="input-group">
                    <div class="input-group-addon">
                        <i class="fa fa-calendar"></i>
                    </div>
                    <asp:TextBox ID="calDOB" class="form-control" placeholder="MM/DD/YYYY" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Previous School Name & Standard" ID="lblPrevSchoolName" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtPrevSchoolName" class="form-control" placeholder="Previous School"
                    runat="server"></asp:TextBox>
                <asp:DropDownList ID="txtPrevStandard" class="form-control" runat="server">
                <asp:ListItem Text="Nursary" Value="Nursary"></asp:ListItem>
                <asp:ListItem Text="LKG" Value="LKG"></asp:ListItem>
                <asp:ListItem Text="SKG" Value="SKG"></asp:ListItem>
                <asp:ListItem Text="1" Value="1" Selected="True"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                <asp:ListItem Text="9" Value="9"></asp:ListItem>
                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Admission Date" ID="lblAdmissionDate" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <div class="input-group">
                    <div class="input-group-addon">
                        <i class="fa fa-calendar"></i>
                    </div>
                    <asp:TextBox ID="CalAdmissionDate" class="form-control" placeholder="MM/DD/YYYY"
                        runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Class" ID="lblClass" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="dropdown-menu-right">
                <asp:DropDownList ID="txtClass" class="form-control" runat="server">
                <asp:ListItem Text="Nursary" Value="Nursary"></asp:ListItem>
                <asp:ListItem Text="LKG" Value="LKG"></asp:ListItem>
                <asp:ListItem Text="SKG" Value="SKG"></asp:ListItem>
                <asp:ListItem Text="1" Value="1" Selected="True"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                <asp:ListItem Text="9" Value="9"></asp:ListItem>
                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Pending Documents" ID="lblPendingDocs" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtPendingDocs" class="form-control" placeholder="Enter Pending Documents List"
                    runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Progress" ID="lblProgress" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtProgress" class="form-control" placeholder="Progress" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Conduct" ID="lblConduct" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtConduct" class="form-control" placeholder="Conduct" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Date of Leaving School" ID="lblDOL" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <div class="input-group">
                    <div class="input-group-addon">
                        <i class="fa fa-calendar"></i>
                    </div>
                    <asp:TextBox ID="txtDOL" class="form-control" placeholder="MM/DD/YYYY" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Standard in which studying and since" ID="lblStandard" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="txtStandard" class="form-control" runat="server">
                <asp:ListItem Text="Nursary" Value="Nursary"></asp:ListItem>
                <asp:ListItem Text="LKG" Value="LKG"></asp:ListItem>
                <asp:ListItem Text="SKG" Value="SKG"></asp:ListItem>
                <asp:ListItem Text="1" Value="1" Selected="True"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                <asp:ListItem Text="9" Value="9"></asp:ListItem>
                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Reason of Leaving the School" ID="lblReasonLeaving" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtReasonLeaving" class="form-control" placeholder="Reason of Leaving the School"
                    runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Remarks" ID="lblRemarks" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtRemarks" class="form-control" placeholder="Remarks" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group row">
            <div class="offset-sm-2 col-sm-10">
                <asp:Button ID="btnEdit" class="btn btn-primary" Text="Edit" runat="server" OnClick="btnEdit_Click" />
                <asp:Button ID="btnSubmit" class="btn btn-primary" Text="Submit" runat="server" OnClick="btnSubmit_Click" OnClientClick ="return validate();"/>
                <asp:Button ID="btnGenerateLC" class="btn btn-primary" Text="Generate LC" runat="server"
                    OnClick="btnGenerateLC_Click" />
            </div>
        </div>
        </form>
    </div>
    <!-- Extra JavaScript/CSS added manually in "Settings" tab -->
    <!-- Include jQuery -->
    <!-- Include Date Range Picker -->
    <script type="text/javascript">
        $(document).ready(function () {
            $('#calDOB').val("2000-01-01");
            $('#calDOB').datepicker({
                format: 'yyyy-mm-dd',
                todayHighlight: true,
                autoclose: true
            });

            $('#CalAdmissionDate').val("2000-01-01");
            $('#CalAdmissionDate').datepicker({
                format: 'yyyy-mm-dd',
                todayHighlight: true,
                autoclose: true
            });

            $('#txtDOL').val("2000-01-01");
            $('#txtDOL').datepicker({
                format: 'yyyy-mm-dd',
                todayHighlight: true,
                autoclose: true
            });
        });
    </script>
</body>
</html>
