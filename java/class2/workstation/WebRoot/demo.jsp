<%@page contentType="text/html; charset=GBK" language="java" import="java.util.Calendar"%>
<%!
   String getHello(String name) {
     return "Hi," + name + "!";
   }
%>
<% Calendar now = Calendar.getInstance(); %>
<html>
<head>
   <title>JSP ҳ�湹��</title>
</head> 
   <!-- ����ע��,���ͻ��˿��Բ쿴�� -->
   <%-- ��Ҳ��ע��,���ͻ��˲��ܲ쿴�� --%>
<body>
   <h1 align="center">JSPҳ�湹��</h1>
   <%=getHello("����")%>
   <%=request.getRemoteAddr() %>
   <%if (now.get(Calendar.AM_PM) == Calendar.AM) {%>
     ���Ϻ�!
    <%} else {%>
      �����!
    <%}%>
     <br>
    <br>
    <jsp:include flush="false" page="welcome.jsp">
      <jsp:param name="str" value="����"/>
     </jsp:include>
   </body>
</html>
