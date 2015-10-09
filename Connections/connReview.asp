<%
' FileName="Connection_ado_conn_string.htm"
' Type="ADO" 
' DesigntimeType="ADO"
' HTTP="true"
' Catalog=""
' Schema=""
Dim MM_connReview_STRING
MM_connReview_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="& Server.MapPath("/asp_review/data/review.mdb")
response.charset="utf-8"
%>
