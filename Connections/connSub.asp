<%
' FileName="Connection_ado_conn_string.htm"
' Type="ADO" 
' DesigntimeType="ADO"
' HTTP="true"
' Catalog=""
' Schema=""
Dim MM_connSub_STRING
MM_connSub_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="& Server.MapPath("/online/asp_subject/data/data.mdb")
response.charset="utf-8"
%>
