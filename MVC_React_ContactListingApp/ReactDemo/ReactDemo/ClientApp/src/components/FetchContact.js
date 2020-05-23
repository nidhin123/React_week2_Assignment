import React, { Component } from 'react';

export class FetchContact extends Component {
    static displayName = FetchContact.name;

    constructor(props) {
        super(props);
        this.state = { contacts: [], loading: true };
    }

    componentDidMount() {
        this.populateContactData();
    }

    static renderContactTable(contacts) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Address</th>
                        <th>Email</th>
                    </tr>
                </thead>
                <tbody>
                    {contacts.map(contact =>
                        <tr key={contact.name}>
                            <td>{contact.name}</td>                          
                            <td>{contact.address}</td>
                            <td>{contact.email}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchContact.renderContactTable(this.state.contacts);

        return (
            <div>
                <h1 id="tabelLabel" >Contatct Listing</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateContactData() {
        const response = await fetch('Contact');
        const data = await response.json();
        this.setState({ contacts: data, loading: false });
    }
}
