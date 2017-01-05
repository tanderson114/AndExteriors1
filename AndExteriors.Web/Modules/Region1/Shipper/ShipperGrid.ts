namespace AndExteriors.Region1 {

    @Serenity.Decorators.registerClass()
    export class ShipperGrid extends Serenity.EntityGrid<ShipperRow, any> {
        protected getColumnsKey() { return "Region1.Shipper"; }
        protected getDialogType() { return <any>ShipperDialog; }
        protected getIdProperty() { return ShipperRow.idProperty; }
        protected getLocalTextPrefix() { return ShipperRow.localTextPrefix; }
        protected getService() { return ShipperService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}