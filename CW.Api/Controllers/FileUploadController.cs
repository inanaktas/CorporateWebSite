using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class FileUploadController : BaseApiController
	{

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> Upload(IFormFile file)
		{

			try
			{

				if (file == null || file.Length == 0)

					return BadRequest(new { isSuccess = false, message = "Dosya seçilmedi!" });

				string uploadsFolder = "C:\\Users\\aktas\\source\\repos\\CorporateWebSite4\\CW.WebUI\\wwwroot\\uploadsAboutUs"; //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

				// Eğer uploads klasörü yoksa oluştur
				if (!Directory.Exists(uploadsFolder))

				{
					Directory.CreateDirectory(uploadsFolder);
				}

				string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

				string filePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))

				{
					await file.CopyToAsync(stream);
				}

				string fileUrl = $"/uploadsAboutUs/{uniqueFileName}";
				return Ok(new { isSuccess = true, message = "Dosya başarıyla yüklendi.", filePath = fileUrl });

			}

			catch (Exception ex)

			{
				return StatusCode(500, new { isSuccess = false, message = "Dosya yükleme hatası!", error = ex.Message });
			}

		}



		[HttpPost]
		[Authorize]
		public async Task<IActionResult> UploadAllFiles(List<IFormFile> files)
		{
			try
			{
				if (files == null || files.Count == 0)
					return BadRequest(new { isSuccess = false, message = "Dosya seçilmedi!" });

				string uploadsFolder = "C:\\Users\\aktas\\source\\repos\\CorporateWebSite4\\CW.WebUI\\wwwroot\\uploadsProjects";

				// Eğer uploads klasörü yoksa oluştur
				if (!Directory.Exists(uploadsFolder))
				{
					Directory.CreateDirectory(uploadsFolder);
				}

				List<string> filePaths = new List<string>();

				foreach (var file in files)
				{
					if (file == null || file.Length == 0)
						continue;

					string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
					string filePath = Path.Combine(uploadsFolder, uniqueFileName);

					// Dosyayı kaydet
					using (var stream = new FileStream(filePath, FileMode.Create))
					{
						await file.CopyToAsync(stream);
					}

					string fileUrl = $"/uploadsProjects/{uniqueFileName}";
					filePaths.Add(fileUrl); // Listeye ekle
				}

				if (filePaths.Count == 0)
				{
					return BadRequest(new { isSuccess = false, message = "Dosyalar yüklenemedi!" });
				}

				return Ok(new { isSuccess = true, message = "Dosyalar başarıyla yüklendi.", filePaths });
			}
			catch (Exception ex)
			{
				return StatusCode(500, new { isSuccess = false, message = "Dosya yükleme hatası!", error = ex.Message });
			}
		}



		[HttpPost]
		[Authorize]
		public async Task<IActionResult> UploadHomeFile(IFormFile file)
		{

			try
			{

				if (file == null || file.Length == 0)

					return BadRequest(new { isSuccess = false, message = "Dosya seçilmedi!" });

				string uploadsFolder = "C:\\Users\\aktas\\source\\repos\\CorporateWebSite4\\CW.WebUI\\wwwroot\\uploadsHome"; //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

				// Eğer uploads klasörü yoksa oluştur
				if (!Directory.Exists(uploadsFolder))

				{
					Directory.CreateDirectory(uploadsFolder);
				}

				string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

				string filePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))

				{
					await file.CopyToAsync(stream);
				}

				string fileUrl = $"/uploadsHome/{uniqueFileName}";
				return Ok(new { isSuccess = true, message = "Dosya başarıyla yüklendi.", filePath = fileUrl });

			}

			catch (Exception ex)

			{
				return StatusCode(500, new { isSuccess = false, message = "Dosya yükleme hatası!", error = ex.Message });
			}

		}


		[HttpPost]
		[Authorize]
		public async Task<IActionResult> UploadTeamFile(IFormFile file)
		{

			try
			{

				if (file == null || file.Length == 0)

					return BadRequest(new { isSuccess = false, message = "Dosya seçilmedi!" });

				string uploadsFolder = "C:\\Users\\aktas\\source\\repos\\CorporateWebSite4\\CW.WebUI\\wwwroot\\uploadsTeam"; //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

				// Eğer uploads klasörü yoksa oluştur
				if (!Directory.Exists(uploadsFolder))

				{
					Directory.CreateDirectory(uploadsFolder);
				}

				string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

				string filePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))

				{
					await file.CopyToAsync(stream);
				}

				string fileUrl = $"/uploadsTeam/{uniqueFileName}";
				return Ok(new { isSuccess = true, message = "Dosya başarıyla yüklendi.", filePath = fileUrl });

			}

			catch (Exception ex)

			{
				return StatusCode(500, new { isSuccess = false, message = "Dosya yükleme hatası!", error = ex.Message });
			}

		}

		[HttpPost]
		[Authorize]
		public async Task<IActionResult> UploadCareerFile(IFormFile file)
		{

			try
			{

				if (file == null || file.Length == 0)

					return BadRequest(new { isSuccess = false, message = "Dosya seçilmedi!" });

				string uploadsFolder = "C:\\Users\\aktas\\source\\repos\\CorporateWebSite4\\CW.WebUI\\wwwroot\\uploadsCareer"; //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

				// Eğer uploads klasörü yoksa oluştur
				if (!Directory.Exists(uploadsFolder))

				{
					Directory.CreateDirectory(uploadsFolder);
				}

				string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

				string filePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))

				{
					await file.CopyToAsync(stream);
				}

				string fileUrl = $"/uploadsCareer/{uniqueFileName}";
				return Ok(new { isSuccess = true, message = "Dosya başarıyla yüklendi.", filePath = fileUrl });

			}

			catch (Exception ex)

			{
				return StatusCode(500, new { isSuccess = false, message = "Dosya yükleme hatası!", error = ex.Message });
			}

		}


	}
}
