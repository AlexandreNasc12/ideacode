using FluentValidation.Results;
using ideacode.core.Communication;
using ideacode.core.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace ideacode.api.core.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        protected ICollection<string> Erros = new List<string>();

        protected ICollection<ResponseErrors> ObjectErrors = new List<ResponseErrors>();

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = Erros.ToArray()
            });
        }

        protected ActionResult CustomResponseObjects(object result = null)
        {
            if (OperacaoValidaObject())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = ObjectErrors.ToList()
            });
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                AdicionarErroProcessamento(erro.ErrorMessage);
            }

            return CustomResponse();
        }

        protected ActionResult CustomResponseObjects(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);

            foreach (var erro in erros)
            {
                var erroObject = new ResponseErrors(){name = erro.ErrorMessage.ToCamelCase()};

                erroObject.AtribuirMensagemdeErro();

                AdicionarErroObjectProcessamento(erroObject);
            }

            return CustomResponseObjects();
        }
        
        protected ActionResult CustomResponse(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                AdicionarErroProcessamento(erro.ErrorMessage);
            }

            return CustomResponse();
        }
        
        protected ActionResult CustomResponse<T>(ResponseResult resposta) 
        {
            ResponsePossuiErros(resposta);

            return CustomResponse(JsonConvert.DeserializeObject<List<T>>(resposta.data.ToString() ?? string.Empty));
        }

        protected bool ResponsePossuiErros(ResponseResult resposta)
        {
            if (resposta == null || resposta.errors == null || !resposta.errors.Any()) return false;

            foreach (var mensagem in resposta.errors)
            {
                AdicionarErroProcessamento(mensagem);
            }

            return true;
        }


        protected bool OperacaoValida()
        {
            return !Erros.Any();
        }

        protected bool OperacaoValidaObject()
        {
            return !ObjectErrors.Any();
        }

        protected void AdicionarErroProcessamento(string erro)
        {
            Erros.Add(erro);
        }

        protected void AdicionarErroObjectProcessamento(ResponseErrors erro)
        {
            ObjectErrors.Add(erro);
        }

        protected void LimparErrosProcessamento()
        {
            Erros.Clear();
        }
    }

    public class ResponseErrors
    {
        public string name { get; set; }

        public string errorMessage { get; private set; }

        public void AtribuirMensagemdeErro()
        {
            errorMessage = $"O campo é obrigatório!";
        }
    }
}
