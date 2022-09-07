using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator: AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen Ürün Adını Boş Geçmeyiniz !")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("En az 2 karakter En fazla 150 karakter giriniz.");
            RuleFor(p => p.Stock)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen Stok bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                    .WithMessage("Stok bilgisi negatif olamaz!");
            RuleFor(p => p.Price)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen Fiyat bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisi negatif olamaz!");

        }
    }
}
