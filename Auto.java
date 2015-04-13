package com.bench.asd.main;

public class Auto {
	
	private int motor;
	private String tipus;
	
	
	public Auto(int motor, String tipus) {
		this.motor = motor;
		this.tipus = tipus;
	}


	public int getMotor() {
		return motor;
	}


	public void setMotor(int motor) {
		this.motor = motor;
	}


	public String getTipus() {
		return tipus;
	}


	public void setTipus(String tipus) {
		this.tipus = tipus;
	}


	@Override
	public String toString() {
		return "Auto [motor=" + motor + ", tipus=" + tipus + "]";
	}
	
	
	
	

}
