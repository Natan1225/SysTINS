using SysTINSClass;

public class Endereco

{

    public int Id { get; set; }

    public int Cliente_id { get; set; }

    public string? Cep { get; set; }

    public string? Logradouro { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Uf { get; set; }

    public string? Tipo_Endereco { get; set; }

    public Endereco() { }

    public Endereco(int id, int cliente_id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoendereco)

    {

        Id = id;

        Cliente_id = cliente_id;

        Cep = cep;

        Logradouro = logradouro;

        Numero = numero;

        Complemento = complemento;

        Bairro = bairro;

        Cidade = cidade;

        Uf = uf;

        Tipo_Endereco = tipoendereco;

    }

    public Endereco(int id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoendereco)

    {

        Id = id;
        Cep = cep;
        Logradouro = logradouro;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Uf = uf;
        Tipo_Endereco = tipoendereco;

    }

    public void Inserir()
    {
        var cmd = Banco.Abrir();
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.CommandText = "sp_endereco_insert";
        cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
        cmd.Parameters.AddWithValue("spcep", Cep);
        cmd.Parameters.AddWithValue("splogradouro", Logradouro);
        cmd.Parameters.AddWithValue("spnumero", Numero);
        cmd.Parameters.AddWithValue("spcomplemento", Complemento);

        cmd.Parameters.AddWithValue("spbairro", Bairro);

        cmd.Parameters.AddWithValue("spcidade", Cidade);

        cmd.Parameters.AddWithValue("spuf", Uf);

        cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);

        cmd.ExecuteNonQuery();

        cmd.Connection.Close();

    }

    public static Endereco ObterListaPorClienteId(int id)

    {

        Endereco list = new();

        var cmd = Banco.Abrir();

        cmd.CommandText = $"select * from enderecos where id = {id}";

        var dr = cmd.ExecuteReader();

        while (dr.Read())

        {

            list = new(

                dr.GetInt32(0),

                dr.GetInt32(1),

                dr.GetString(2),

                dr.GetString(3),

                dr.GetString(4),

                dr.GetString(5),

                dr.GetString(6),

                dr.GetString(7),

                dr.GetString(8),

                dr.GetString(9)

                );

        }

        return list;

    }

    public bool Atualizar()

    {

        bool resposta = false;

        var cmd = Banco.Abrir();

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.CommandText = "sp_endereco_update";

        cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);

        cmd.Parameters.AddWithValue("spcep", Cep);

        cmd.Parameters.AddWithValue("splogradouro", Logradouro);

        cmd.Parameters.AddWithValue("spnumero", Numero);

        cmd.Parameters.AddWithValue("spcomplemento", Complemento);

        cmd.Parameters.AddWithValue("spbairro", Bairro);

        cmd.Parameters.AddWithValue("spcidade", Cidade);

        cmd.Parameters.AddWithValue("spuf", Uf);

        cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);

        if (cmd.ExecuteNonQuery() > 0)

        {

            cmd.Connection.Close();

            resposta = true;

        }

        return resposta;

    }

    public void Excluir()
    {

        var cmd = Banco.Abrir();

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.CommandText = "sp_categoria_delete";

        cmd.Parameters.AddWithValue("spid", Id);

        cmd.ExecuteNonQuery();

        cmd.Connection.Close();

    }
}
