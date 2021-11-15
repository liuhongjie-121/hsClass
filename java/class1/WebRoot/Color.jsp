<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<style type="text/css">

</style>
</head>
<body>
<% 
	String[] arrList = new String[]{"Green","Cyan","Black","Red","Yellow","Pink"};
	for(int i = 0;i <arrList.length;i++){		
%>
<span><%= arrList[i] %></span>
<hr color="<%= arrList[i] %>" style="height:50px">
<% } %>
</body>
</html>