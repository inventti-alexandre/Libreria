UPDATE  stockCorrientes
SET
		stockCorrientes.StkCn = stockCorrientes.StkCn - tmFeria.CntMinCn,
		stockCorrientes.StkPr = stockCorrientes.StkPr - tmFeria.CntMinPr
FROM
        LCorrientes.dbo.TitulosStock stockCorrientes
        INNER JOIN 
			(
				select TituloId, SUM(CntMinCn) as CntMinCn , SUM(CntMinPr) as CntMinPr
				from LCorrientesFeria.dbo.TitulosMovimiento tm
				where tm.Id >  1497460
				GROUP BY tm.TituloId	
			) 
		tmFeria 
		ON (tmFeria.TituloId = stockCorrientes.TituloId)



		
 -- select TituloId, SUM(CntMinCn) as CntMinCn , SUM(CntMinPr) as CntMinPr
 -- from LCorrientesFeria.dbo.TitulosMovimiento tm
 -- where tm.Id >  1497460
 -- GROUP BY tm.TituloId