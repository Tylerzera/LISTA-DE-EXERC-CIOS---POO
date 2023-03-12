class ManipularArquivo {

    public string Conteudo;
    public string EnderecoNomeArquivo;

    public bool SalvarDadosEArquivo(){
        try{
        if(!File.Exists(EnderecoNomeArquivo))
            File.Create(EnderecoNomeArquivo).Close();
        
        StreamWriter sw = new StreamWriter(EnderecoNomeArquivo);
        sw.Write(Conteudo);
        sw.Close();
        return true; 
        }
        catch(Exception ex){  
        Console.WriteLine(ex.ToString());
        return false;
        } 
    }

    public string PesquisarConteudoArquivo(string endereco){
        if(!File.Exists(endereco))
        return "";

        StreamReader sr = new StreamReader (endereco);
        string conteudo = sr.ReadToEnd();
        sr.Close();
        return conteudo;

      }
}