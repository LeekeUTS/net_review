<!-- Bootstrap -->
<% 
dim head
head="../"
 %>
<!-- Latest compiled and minified CSS -->
<link href="<%= head %>assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css">

<!-- Optional theme -->
<link rel="stylesheet" href="<%= head %>assets/bootstrap/css/bootstrap-theme.min.css">
<!-- OOCSS -->
<link rel="stylesheet" href="<%= head %>assets/oocss.css">
<!-- Optional theme -->
<link rel="stylesheet" href="<%= head %>assets/bootstrap/css/bootstrap-docs.css">
<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
<!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="<%= head %>assets/jquery.min.js"></script>
<script src="../SpryAssets/SpryData.js" type="text/javascript"></script>
<script src="../SpryAssets/SpryHTMLDataSet.js" type="text/javascript"></script>
<script src="../SpryAssets/xpath.js" type="text/javascript"></script>
<script src="../SpryAssets/SpryURLUtils.js" type="text/javascript"></script>
<% 
host=Request.ServerVariables("HTTP_HOST")
if host="www.tvxqshare.com" then
%>
<link rel="stylesheet" href="<%= head %>assets/admin.css">
<!-- Optional theme -->
<link href="../assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css">

<!-- OOCSS -->
<link rel="stylesheet" href="../assets/oocss.css">
<% End if %>

<% 
	getID=request.QueryString("id")
	getCID=request.QueryString("cid")
%>