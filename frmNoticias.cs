using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsAPI;
using Newtonsoft.Json;

namespace Asistente_virtual
{
    public partial class frmNoticias : Form
    {
        public frmNoticias()
        {
            InitializeComponent();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic articlesResponse = null;
                // init with your API key (get this from newsapi.org)
                var newsApiClient = new NewsApiClient("TuApiKey");
                switch (cbxSortBy.Text)
                {
                    case "Popularity":
                        articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
                        {
                            Q = "Argentina",
                            Language = Languages.ES,
                            SortBy = SortBys.Popularity,
                            PageSize = Convert.ToInt32(nudPages.Value)
                        });
                        break;

                    case "Relevancy":
                        articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
                        {
                            Q = "Argentina",
                            Language = Languages.ES,
                            SortBy = SortBys.Relevancy,
                            PageSize = Convert.ToInt32(nudPages.Value)
                        });
                        break;

                    case "PublishedAt":
                        articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
                        {
                            Q = "Argentina",
                            Language = Languages.ES,
                            SortBy = SortBys.PublishedAt,
                            PageSize = Convert.ToInt32(nudPages.Value)
                        });
                        break;

                    case "":
                        articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
                        {
                            Q = "Argentina",
                            Language = Languages.ES,
                            SortBy = SortBys.Popularity,
                            PageSize = Convert.ToInt32(nudPages.Value)
                        });
                        break;
                }

                if (articlesResponse?.Status == Statuses.Ok)
                {
                    // total results found
                    //Console.WriteLine(articlesResponse.TotalResults);

                    txtbNoticias.Clear();

                    // here's the first 20
                    foreach (var article in articlesResponse.Articles)
                    {
                        if (txtbNoticias.Text.Length > 0)
                        {
                            txtbNoticias.AppendText("\n");
                            txtbNoticias.AppendText("\n");
                        }

                        // add the article title and author
                        txtbNoticias.AppendText($"~{article.Title} - {article.Author}");
                        txtbNoticias.AppendText("\n");
                        // description
                        txtbNoticias.AppendText($"Descripción: {article.Description}");
                        txtbNoticias.AppendText("\n");
                        txtbNoticias.AppendText($"Url: {article.Url}");
                        txtbNoticias.ScrollToCaret();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmNoticias_Load(object sender, EventArgs e)
        {

        }
    }
}

