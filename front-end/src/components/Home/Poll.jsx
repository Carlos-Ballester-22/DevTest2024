import Option from './Option';

export default function Pool(props) {

    return (
        <div>
            <div>
                <h3>{props.name}</h3>
                <div>
                <Option options={props.options}/>
                </div>
            </div>
        </div>
    );
}