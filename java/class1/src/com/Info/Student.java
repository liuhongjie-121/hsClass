package com.Info;

public class Student {
	private String Sno;// ѧ��
	private String Name;// ����
	private String Sex;// �Ա�
	private String Cla;// �༶
	private Double Grade;// �ɼ�
	
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
