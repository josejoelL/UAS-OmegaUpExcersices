package Modelos;

public class cilindro extends circulo {
	protected float altura;

	public cilindro() {
		super();
		this.altura=0;
	}

	public cilindro(float radio,float altura) {
		this.radio=radio;
		this.altura=altura;
	}

	public float getAltura() {
		return altura;
	}

	public void setAltura(float altura) {
		this.altura = altura;
	}
	public double volumen()
	{
		 final float PI = 3.1416f;
		return PI*(this.radio*this.radio)*this.altura;
	}
	@Override
	public float area()
	{
		final float PI = 3.1416f;
		return 2*PI *this.radio*this.altura + 2*PI*(this.radio*this.radio);
	}

}
