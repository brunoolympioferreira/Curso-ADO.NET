SELECT * FROM Usuarios u 
    LEFT JOIN Contatos c ON c.UsuarioId = u.Id
    LEFT JOIN EnderecosEntrega ee ON ee.UsuarioId = u.Id
    LEFT JOIN UsuariosDepartamentos ud ON ud.UsuarioId = u.Id
    LEFT JOIN Departamentos d ON ud.DepartamentoId = d.Id
    WHERE u.Id = 1