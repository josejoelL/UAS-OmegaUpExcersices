package Modelos;

public class cilindroHueco extends cilindro {
	private float radioInterno;

	public cilindroHueco() {
		super();
		this.radioInterno=0;
	}

	public cilindroHueco(float radio, float altura, float radioInterno) {
		this.radio=radio;
		this.altura=altura;
		this.radioInterno=radioInterno;
	}

	public float getRadioInterno() {
		return radioInterno;
	}

	public void setRadioInterno(float radioInterno) {
		this.radioInterno = radioInterno;
	}
	@Override
    public double volumen()
    {
        return Math.PI * (this.radio*this.radio)-
        (this.radioInterno*this.radioInterno) * this.altura;

    }
	@Override
    public double longitud()
    {
        return 2 * Math.PI * (this.radio*this.radio)- (this.radioInterno*this.radioInterno) + 2 * Math.PI * this.radio * this.altura + 2 * Math.PI * this.altura * this.radioInterno;
    }
	
	
	
	
	
}
