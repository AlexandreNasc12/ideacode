using System.ComponentModel.DataAnnotations;

namespace ideacode.api.InputModel;

public class ContatoInputModel
{
    [Required(ErrorMessage = "Informe seu nome!")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "Informe um e-mail para de contato!")]
    [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Informe um número de telefone para contato!")]
    [RegularExpression(@"(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})", ErrorMessage = "Numero do celular está no formato inválido!")]
    public string Telefone { get; set; }
    
    public string Empresa { get; set; }
    
    public string Assunto { get; set; }
    
    [Required(ErrorMessage = "Descreva sua mensagem!")]
    public string Mensagem { get; set; }
}