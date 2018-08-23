class ModalNovoSeguro extends React.Component {
    render() {
        return (
            <div class="modal fade" id="modalNovoSeguro" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title">Novo Seguro</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <form>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Nome do Cliente</label>
                                    <input type="text" class="form-control" id="exampleInputEmail1" placeholder="Aqui vai o nome do contratante"/>
                                    <small id="emailHelp" class="form-text text-muted">Insira o nome completo da pessoa que está contratando o seguro.</small>
                                </div>

                                <div class="form-group">
                                    <label for="exampleFormControlSelect1">Tipo de Seguro</label>
                                    <select class="form-control" id="exampleFormControlSelect1">
                                        <option>Residencial</option>
                                        <option>Automotivo</option>
                                        <option>Vida</option>
                                    </select>
                                    <small id="emailHelp" class="form-text text-muted">Cada seguro pede um tipo diferente de identificação.</small>
                                </div>

                                <div class="form-group">
                                    <label for="exampleInputEmail1">Identificação do Bem Segurado</label>
                                    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Aqui vai a identificação do segurado" />
                                    <small id="emailHelp" class="form-text text-muted">Residencial: endereço (Ex.: Rua Exemplo, 299)</small>
                                    <small id="emailHelp" class="form-text text-muted">Automotivo: placa (Ex.: AAA-0000)</small>
                                    <small id="emailHelp" class="form-text text-muted">Vida: CPF (Ex.: 000.001.002-33)</small>
                                </div>
                            </form>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                            <button type="button" class="btn btn-primary">Salvar</button>
                        </div>
                    </div>
                </div>
            </div>
    )}
}


class TabelaSeguros extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            linhas: [{ a:1, b:1, c:1, d:1}, {a:2,b:2,c:2,d:2}]
        }
    }

    render() {
        return (
            <div>
                <table class="table">
                    <tr>
                        <th>ID</th>
                        <th>Cliente</th>
                        <th>Tipo</th>
                        <th>Segurado</th>
                    </tr>
                    {this.state.linhas.map(e => {
                        return (
                            <tr>
                                <td>{e.a}</td>
                                <td>{e.b}</td>
                                <td>{e.c}</td>
                                <td>{e.d}</td>
                            </tr>
                        )
                    })}
                </table>
            </div>
    )}
}

class HomeApp extends React.Component {
    render() {
        return (
            <div className="HomeApp">
                <button type="button"
                    class="btn btn-success"
                    data-toggle="modal"
                    data-target="#modalNovoSeguro">
                        Novo Seguro
                </button>

                <TabelaSeguros />

                <ModalNovoSeguro/>
            </div>
        );
    }
}

ReactDOM.render(
    <HomeApp />,
    document.getElementById('content')
);