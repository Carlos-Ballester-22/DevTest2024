
export default function Option(props) {
    
    
    return (
        <div>
            {props.options((option) => {
                <div key={option.id}>
                    <h4>{option.name}</h4>
                    <h5>{option.votes}</h5>
                </div>
            })}
        </div>
    );
}