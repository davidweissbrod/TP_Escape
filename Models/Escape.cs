static class Escape{
    private static string[] incognitasSalas{get; set;} = new string [4];
    private static int estadoJuego{get; set;} = 1;

    private static void InicializarJuego(){
        incognitasSalas[0] = "ALEXIS SANCHEZ";
        incognitasSalas[1] = "DIEGO MARADONA";
        incognitasSalas[2] = "MARCO REUS";
        incognitasSalas[3] = "VAN DE BEEK";
    }

    public static int GetEstadoJuego(){
        return estadoJuego;
    }

    public static bool ResolverSala(int sala, string incongnita){
        bool devolver = false;
        if(estadoJuego <= sala) devolver = false;
        if(incongnita == incognitasSalas[sala - 1]){
            devolver = true;
            estadoJuego++;
        } 
        return devolver;
    }
}

