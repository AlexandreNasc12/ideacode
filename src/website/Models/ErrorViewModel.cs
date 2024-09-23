using System.ComponentModel.DataAnnotations;

namespace website.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

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
    
    public string subject { get; set; }
    
    [Required(ErrorMessage = "Descreva sua mensagem!")]
    public string Message { get; set; }
}
