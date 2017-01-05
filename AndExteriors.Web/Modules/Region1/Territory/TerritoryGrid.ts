namespace AndExteriors.Region1 {

    @Serenity.Decorators.registerClass()
    export class TerritoryGrid extends Serenity.EntityGrid<TerritoryRow, any> {
        protected getColumnsKey() { return "Region1.Territory"; }
        protected getDialogType() { return <any>TerritoryDialog; }
        protected getIdProperty() { return TerritoryRow.idProperty; }
        protected getLocalTextPrefix() { return TerritoryRow.localTextPrefix; }
        protected getService() { return TerritoryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}