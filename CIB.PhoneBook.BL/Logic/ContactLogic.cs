using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Xml;
using CIB.PhoneBook.BL.Interfaces;
using CIB.PhoneBook.DAL.Dtos;
using CIB.PhoneBook.DAL.Model;
using CIB.PhoneBook.DAL.Repositories;

namespace CIB.PhoneBook.BL.Logic
{
    public class ContactLogic : ICrud<ContactDto, Contact>
    {
        private ContactRepository Repository { get; } = new ContactRepository();
        private ContactDtoMapper ContactMapper { get; } = new ContactDtoMapper();

        public ContactDto Create(ContactDto item)
        {
            try
            {
                var result = Repository.Add(MapDtoToModel(item));
                return result != null ? MapModelToDto(result) : null;
            }
            catch (DbEntityValidationException dbx)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = dbx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(dbx.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Exception(exceptionMessage);
            }            
            catch (System.Exception ex)
            {
                //new ErrorHandler("Svc").HandleError(ex, new RequestBase());
                return null;
            }
        }

        public ContactDto Delete(ContactDto item)
        {
            try
            {
                var result = Repository.Remove(MapDtoToModel(item));
                return result != null ? MapModelToDto(result) : null;
            }
            catch (DbEntityValidationException dbx)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = dbx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(dbx.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Exception(exceptionMessage);
            }            
            catch (System.Exception ex)
            {
                //new ErrorHandler("Svc").HandleError(ex, new RequestBase());
                return null;
            }
        }

        public ContactDto Update(ContactDto item)
        {
            try
            {
                var result = Repository.Update(item.Id, MapDtoToModel(item));
                return result != null ? MapModelToDto(result) : null;
            }
            catch (DbEntityValidationException dbx)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = dbx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(dbx.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Exception(exceptionMessage);
            }            
            catch (System.Exception ex)
            {
                //new ErrorHandler("Svc").HandleError(ex, new RequestBase());
                return null;
            }
        }

        public IQueryable<ContactDto> GetAll()
        {
            try
            {
                var dtos = new List<ContactDto>();
                var models = Repository.GetAll().ToList();
                if (models.Any())
                {
                    dtos.AddRange(models.Select(model => MapModelToDto(model)));
                }
                return dtos.AsQueryable();
            }
            catch (DbEntityValidationException dbx)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = dbx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(dbx.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Exception(exceptionMessage);
            }            
            catch (System.Exception ex)
            {
                //new ErrorHandler("Svc").HandleError(ex, new RequestBase());
                return null;
            }
            
        }

        public ContactDto GetById(int id)
        {
            try
            {
                var model = Repository.Get(id);
                return model != null ? MapModelToDto(model) : null;
            }
            catch (DbEntityValidationException dbx)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = dbx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(dbx.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Exception(exceptionMessage);
            }            
            catch (System.Exception ex)
            {
                //new ErrorHandler("Svc").HandleError(ex, new RequestBase());
                return null;
            }
        }

        public ContactDto SearchFirst(Expression<Func<Contact, bool>> predicate)
        {
            try
            {
                var model = Repository.SearchFirst(predicate);
                return model != null ? MapModelToDto(model) : null;
            }
            catch (DbEntityValidationException dbx)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = dbx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(dbx.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Exception(exceptionMessage);
            }
            catch (System.Exception ex)
            {
                //new ErrorHandler("Svc").HandleError(ex, new RequestBase());
                return null;
            }
        }

        public List<ContactDto> SearchFor(Expression<Func<Contact, bool>> predicate)
        {
            try
            {
                var results = new List<ContactDto>();
                var models = Repository.SearchFor(predicate).ToList();
                if (models.Any())
                {
                    results.AddRange(models.Select(model => MapModelToDto(model)));
                }
                return results;
            }
            catch (DbEntityValidationException dbx)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = dbx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(dbx.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Exception(exceptionMessage);
            }            
            catch (System.Exception ex)
            {
                //new ErrorHandler("Svc").HandleError(ex, new RequestBase());
                return null;
            }
        }

        public Contact MapDtoToModel(ContactDto contactDto) => ContactMapper.MapToModel(contactDto);
        public ContactDto MapModelToDto(Contact contact) => ContactMapper.MapToDto(contact);


    }
}