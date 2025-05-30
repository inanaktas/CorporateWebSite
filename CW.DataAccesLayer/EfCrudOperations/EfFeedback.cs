using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;
using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IDataAccess;

namespace CW.DataAccesLayer.EfCrudOperations
{
	public class EfFeedback : IEfFeedback
	{


		public int Save(FeedbackDataModel pModel)
		{
			using (CorporateDBContext db = new CorporateDBContext())
			{
				if (pModel.Id > 0)
				{
					var existing = db.Feedbacks.FirstOrDefault(x => x.Id == pModel.Id);
					if (existing != null)
					{
						// SADECE DOLU GELEN ALANLARI GÜNCELLE
						if (pModel.IsRead.HasValue)
							existing.IsRead = pModel.IsRead.Value;

						if (pModel.IsPending.HasValue)
							existing.IsPending = pModel.IsPending.Value;

						// Diğer alanlara DOKUNMA (Name, Email, vs.)
					}
				}
				else
				{
					// Yeni kayıt için tüm alanlar gereklidir
					Feedback model = new Feedback()
					{
						Name = pModel.Name,
						Surname = pModel.Surname,
						Email = pModel.Email,
						PhoneNumber = pModel.PhoneNumber,
						Message = pModel.Message,
						IsRead = pModel.IsRead ?? false,
						IsPending = pModel.IsPending ?? false
					};

					db.Feedbacks.Add(model);
				}

				return db.SaveChanges();
			}
		}

		public int Update(FeedbackUpdateDataModel pModel)
		{
			using (CorporateDBContext db = new CorporateDBContext())
			{
				var feedback = db.Feedbacks.FirstOrDefault(x => x.Id == pModel.Id);

				if (feedback == null)
				{
					return 0;
				}

				// Sadece IsRead ve IsPending güncellenir
				if (pModel.IsRead.HasValue)
				{
					feedback.IsRead = pModel.IsRead.Value;
				}

				if (pModel.IsPending.HasValue)
				{
					feedback.IsPending = pModel.IsPending.Value;
				}

				return db.SaveChanges();

			}

		}


		public List<FeedbackDataModel> Get()
		{
			using (CorporateDBContext db = new CorporateDBContext())
			{
				var query = db.Feedbacks.AsQueryable();

				var feedbackContentList = query.Select(i => new FeedbackDataModel
				{
					Id = i.Id,
					Name = i.Name,
					Surname = i.Surname,
					Email = i.Email,
					PhoneNumber = i.PhoneNumber,
					Message = i.Message,
					IsRead = i.IsRead,
					IsPending = i.IsPending

				}).ToList();

				return feedbackContentList;
			}
		}

		public int Delete(int pId)
		{
			using (CorporateDBContext db = new CorporateDBContext())
			{
				Feedback model = db.Feedbacks.Where(i => i.Id == pId).FirstOrDefault();
				if (model != null)
				{
					db.Feedbacks.Remove(model);
					return db.SaveChanges();
				}
				return 0;
			}

		}

	}
}
