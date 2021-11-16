package com.info;

public class string {	
	public String getBirthday(String id){
		StringBuilder sb = new StringBuilder();
		sb.append(id.substring(6,10)).append("-").append(id.substring(10,12)).append("-").append(id.substring(12,14));				
		return sb.toString();
	}
	
	public double fun(int x, int y){
		return x / y;
	}
}
