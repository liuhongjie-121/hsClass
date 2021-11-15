<%@page contentType="text/html; charset=GBK" language="java" import="java.util.Calendar"%>
<%!
   String getHello(String name) {
     return "Hi," + name + "!";
   }
%>
<% Calendar now = Calendar.getInstance(); %>
<html>
<head>
   <title>JSP 页面构成</title>
</head> 
   <!-- 这是注释,但客户端可以察看到 -->
   <%-- 这也是注释,但客户端不能察看到 --%>
<body>
   <h1 align="center">JSP页面构成</h1>
   <%=getHello("朋友")%>
   <%=request.getRemoteAddr() %>
   <%if (now.get(Calendar.AM_PM) == Calendar.AM) {%>
     早上好!
    <%} else {%>
      下午好!
    <%}%>
     <br>
    <br>
    <jsp:include flush="false" page="welcome.jsp">
      <jsp:param name="str" value="参数"/>
     </jsp:include>
   </body>
</html>
