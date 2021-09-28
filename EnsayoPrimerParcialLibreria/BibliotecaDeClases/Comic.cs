namespace BibliotecaDeClases
{
    public class Comic:Publicacion
    {
        private bool esColor;
        public Comic(string nombre, bool esColor, int stock, float valor):base(valor,nombre,stock)
        {
            this.esColor = esColor;
        }
        public override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }

        

    }
}
