т.к. у статей может быть много тегов, а у тегов много статей - связь "многие к многим". Для этого используется дополнительная таблица (ArticleTags)
т.к. нужно вывести статьи в том числе без тегов, поэтому начинаем с таблицы статей (Articles)

SELECT a.Title, t.Name FROM [Articles] a LEFT JOIN [ArticleTags] ats ON a.Id = ats.Article LEFT JOIN [Tags] t ON ats.Tag = t.Id;