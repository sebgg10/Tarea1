namespace Tarea1
{
    internal class Concesionaria{
        private Automovil[] _automoviles;
        private int _limiteAtuomoviles;
        private int _automovilesActuales;

        public Concesionaria(int limiteAtuomoviles){
            this._automoviles = new Automovil[limiteAtuomoviles];
            _limiteAtuomoviles = limiteAtuomoviles;
            this._automovilesActuales = 0;
        }

        public void agregarAuto(Automovil a){            
            if (a !=null && _automovilesActuales < _limiteAtuomoviles)
            {
                _automoviles[_automovilesActuales] = a;
            }
            _automovilesActuales += 1;
        }

        public void mostrarAuto(Automovil a){
            Console.WriteLine("Caracteristicas del auto: " + a.ToString());
        }


        /*public void eliminarAuto(Automovil a){
            if (_automovilesActuales > 0)
            {
                for (int i = 0; i < _automovilesActuales; i++)
                {
                    if (a.id == _automoviles[i].id)
                    {
                        _automoviles[i] = null;
                    }
                }
            }
        }*/

        public void mostrarAutos(){
            Console.WriteLine("Los autos disponibles son los siguientes: ");
            foreach (Automovil b in _automoviles)
            {
                Console.WriteLine(b.ToString() + "\n");
            }
        }

        public void vaciarConcesionaria(){
            Array.Clear(_automoviles, 0,_automovilesActuales);
        }
    }
}