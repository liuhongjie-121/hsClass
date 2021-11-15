package com.Info;

public class Student {
	private String Sno;// 学号
	private String Name;// 姓名
	private String Sex;// 性别
	private String Cla;// 班级
	private Double Grade;// 成绩
	
	public Student()
	{
		super();
	}
	
	public Student(String sno,String name,String sex,String cla,Double grade) {
		super();
		Sno = sno;
		Name = name;
		Sex = sex;
		Cla = cla;
		Grade = grade;
	}
	
	public String getSon(){
		return Sno;
	}
	public String getName(){
		return Name;
	}
	public String getSex(){
		return Sex;
	}
	public String getCla(){
		return Cla;
	}
	public double getGra(){
		return Grade;
	}
}
