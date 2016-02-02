﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36279
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizzaria.Data.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pizzaria.Data.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into pizz_Inventory
        ///(
        ///	Categoria,
        ///	NomeFornecedor,
        ///	NumDoc,
        ///	NomeProduto,
        ///	Valor,
        ///	Observacoes,
        ///	DataCriacao
        ///)
        ///values
        ///(
        ///	@Categoria,
        ///	@NomeFornecedor,
        ///	@NumeroDoc,
        ///	@NomeProduto,
        ///	@Valor,
        ///	@Observacao,
        ///	@DataCriacao
        ///).
        /// </summary>
        internal static string AddOnInventory {
            get {
                return ResourceManager.GetString("AddOnInventory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update 
        ///	pizz_Customers 
        ///set 
        ///	Telefone = @tel,
        ///	Nome = @nome,
        ///	Endereco = @end,
        ///	Bairro = @barr,
        ///	Numero = @num,
        ///	Complemento = @comp,
        ///	Observacoes = @obs
        ///where
        ///	ID = @id.
        /// </summary>
        internal static string EditCustomer {
            get {
                return ResourceManager.GetString("EditCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select 
        ///	ID,
        ///	Nome, 
        ///	Telefone, 
        ///	Endereco, 
        ///	Bairro, 
        ///	Numero, 
        ///	Complemento, 
        ///	Observacoes 
        ///from 
        ///	pizz_Customers.
        /// </summary>
        internal static string GetCustomer {
            get {
                return ResourceManager.GetString("GetCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select 
        ///	ID,
        ///	Nome, 
        ///	Telefone, 
        ///	Endereco, 
        ///	Bairro, 
        ///	Numero, 
        ///	Complemento, 
        ///	Observacoes 
        ///from 
        ///	pizz_Customers
        ///where
        ///	ID = @id.
        /// </summary>
        internal static string GetCustomerByID {
            get {
                return ResourceManager.GetString("GetCustomerByID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select 
        ///	ID,
        ///	Telefone,
        ///	Nome,
        ///	Endereco,
        ///	Bairro,
        ///	Numero,
        ///	Complemento,
        ///	Observacoes
        ///from 
        ///	pizz_Customers
        ///where
        ///	Nome like &apos;%&apos; + @name + &apos;%&apos;
        ///order by
        ///	Nome.
        /// </summary>
        internal static string GetCustomerByName {
            get {
                return ResourceManager.GetString("GetCustomerByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select 
        ///	ID,
        ///	Nome, 
        ///	Telefone, 
        ///	Endereco, 
        ///	Bairro, 
        ///	Numero, 
        ///	Complemento, 
        ///	Observacoes 
        ///from 
        ///	pizz_Customers
        ///where
        ///	Telefone = @nmbr.
        /// </summary>
        internal static string GetCustomerByNumber {
            get {
                return ResourceManager.GetString("GetCustomerByNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select distinct
        ///	NomeFornecedor,
        ///	NumDoc,
        ///	NomeProduto,
        ///	Valor,
        ///	(
        ///		select COUNT(*)from pizz_Inventory where NomeProduto like &apos;%&apos;+@nome+&apos;%&apos;
        ///	)as Quantidade,
        ///	Observacoes
        ///from
        ///	pizz_Inventory
        ///where
        ///	Categoria = @categoria and
        ///	NomeProduto like &apos;%&apos;+@nome+&apos;%&apos;.
        /// </summary>
        internal static string GetItemByName {
            get {
                return ResourceManager.GetString("GetItemByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into pizz_Customers
        ///(
        ///	Nome, 
        ///	Telefone, 
        ///	Endereco, 
        ///	Bairro, 
        ///	Numero, 
        ///	Complemento, 
        ///	Observacoes,
        ///	DataCriacao
        ///)
        ///values
        ///(
        ///	@Nome,
        ///	@Telefone,
        ///	@Endereco,
        ///	@Bairro,
        ///	@Numero,
        ///	@Complemento,
        ///	@Observacoes,
        ///	@DataCriacao
        ///).
        /// </summary>
        internal static string InsertCustomer {
            get {
                return ResourceManager.GetString("InsertCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into pizz_Orders
        ///(
        ///	ID,
        ///	Cliente,
        ///	Telefone,
        ///	Pedido,
        ///	DataPedido
        ///)
        ///values
        ///(
        ///	@ID,
        ///	@Cliente,
        ///	@Telefone,
        ///	@Pedido,
        ///	@DataPedido
        ///).
        /// </summary>
        internal static string InsertOrder {
            get {
                return ResourceManager.GetString("InsertOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete TOP(1) from
        ///	pizz_Inventory 
        ///where 
        ///	NomeFornecedor = @NomeFornecedor and
        ///	NumDoc = @NumeroDoc and
        ///	NomeProduto = @NomeProduto.
        /// </summary>
        internal static string RemoveItem {
            get {
                return ResourceManager.GetString("RemoveItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to declare @TCC int -- Total de clientes cadastrados
        ///declare @CDM int -- Clientes cadastrados no mes
        ///declare @TP int  -- Total de Pedido
        ///declare @PM int  -- Pedidos no mes
        ///
        ///set @TCC = (select COUNT(*) from pizz_Customers)
        ///set @CDM = (select COUNT(*) from pizz_Customers WHERE MONTH(DataCriacao) = MONTH(GETDATE())  and YEAR(DataCriacao) = YEAR(GETDATE()))
        ///set @TP = (select count(distinct ID) from pizz_Orders)
        ///set @PM = (select COUNT(distinct ID) from pizz_Orders WHERE MONTH(DataPedido) = MONTH(GETDATE()) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Report {
            get {
                return ResourceManager.GetString("Report", resourceCulture);
            }
        }
    }
}
