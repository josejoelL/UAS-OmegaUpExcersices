package Modelos;

public class circulo {
	protected  float  radio;
	public circulo() {
		this.radio =  0.0f;
	}
	public circulo(float  radio) {
		this.radio = radio;
	}
	public float  getRadio() {
		return radio;
	}
	public void setRadio(float  radio) {
		this.radio = radio;
	}
    public float area()
    {
        final float PI = 3.1416f;
        return PI * (this.radio * this.radio);
    }
    public double longitud()
    {
        return 2 * Math.PI *  this.radio;
    }
}
