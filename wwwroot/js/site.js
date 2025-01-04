$(document).ready(function () {
    $('#table-contatos').DataTable({
        "ordering": true,
        "pading": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Monstar _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 até 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros pro pagina",
            "sLoadingRecords": "Carregando...",
            "sPrecessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginato": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }

    });
});

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});

setTimeout(function () {
    $('.alert').fadeOut('hide');
}, 5000);

