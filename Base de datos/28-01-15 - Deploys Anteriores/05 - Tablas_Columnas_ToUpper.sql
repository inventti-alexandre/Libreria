BEGIN TRAN Tran1;

	CREATE TABLE #Tablas (
		Id INT IDENTITY(1,1),
		Nombre VARCHAR(250)
	)
	INSERT INTO #Tablas
			( Nombre )
	SELECT TABLE_NAME
	FROM lapaz.INFORMATION_SCHEMA.TABLES
	WHERE TABLE_SCHEMA='dbo' AND SUBSTRING(TABLE_NAME,1,1)<>'v'

	CREATE TABLE #Columnas (	
		Nombre VARCHAR(250)
	)
	DECLARE @LineaUpDate VARCHAR(250)
	SET @LineaUpDate='UPDATE @NombreTable SET @NombreColumna = UPPER(@NombreColumna)'
	DECLARE @Contador INT
	SET @Contador = 1   
	DECLARE @Regs INT               -- Variable para el Numero de Registros a procesar
	SET @Regs = (SELECT COUNT(*) FROM #Tablas)
	DECLARE @NombreTable VARCHAR(100)
	DECLARE @NombreColumna VARCHAR(100)
	DECLARE @ExecuteUpdate VARCHAR(1000)

	WHILE @Contador <= @Regs
	BEGIN
		SELECT @NombreTable= t.Nombre
		FROM #Tablas t
		WHERE t.Id = @Contador
		
		--Selecciono las columnas de tipo varchar de cada tabla
		INSERT INTO #Columnas (	
			Nombre
		)
		SELECT COLUMN_NAME
		FROM lapaz.INFORMATION_SCHEMA.COLUMNS
		WHERE TABLE_NAME =@NombreTable  AND DATA_TYPE='varchar'
		
		WHILE(Exists(SELECT * FROM #Columnas))
		  BEGIN
				SET @ExecuteUpdate=''
				--Selecciono siempre la primer fila
				select top(1) @NombreColumna=Nombre from #Columnas
				PRINT @NombreTable + ' - ' + @NombreColumna
				SET @ExecuteUpdate=REPLACE(REPLACE(@LineaUpDate,'@NombreColumna',@NombreColumna),'@NombreTable',@NombreTable)
				EXECUTE(@ExecuteUpdate);
				IF @@ERROR<>0
					ROLLBACK TRAN Tran1
				
				--Elimino la primer fila que ya fue actualizada
				delete top(1) from #Columnas;
		  END

		SET @Contador = @Contador + 1 
	END
	--DROP TABLE #Tablas
	--DROP TABLE #Columnas
IF @@ERROR=0
COMMIT TRAN Tran1;
GO


